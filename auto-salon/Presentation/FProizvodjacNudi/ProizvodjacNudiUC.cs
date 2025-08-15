using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FPromotivnePonude;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FProizvodjacNudi
{
    public partial class ProizvodjacNudiUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProizvodjacService _proizvodjacService;
        private IList<ProizvodjacDTO> _proizvodjaci = [];

        public ProizvodjacNudiUC(IServiceProvider serviceProvider, IProizvodjacService proizvodjacService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _proizvodjacService = proizvodjacService;

            this.Dock = DockStyle.Fill;

            // Define columns for ListView lvProizvodjaci
            lvProizvodjaci.Columns.Add("ID");
            lvProizvodjaci.Columns.Add("Naziv");

            // Define columns for ListView lvSaloni
            lvSaloni.Columns.Add("ID");
            lvSaloni.Columns.Add("Naziv");
            lvSaloni.Columns.Add("Adresa");
            lvSaloni.Columns.Add("Grad");
            lvSaloni.Columns.Add("Država");
            lvSaloni.Columns.Add("Kontakt Telefon");
            lvSaloni.Columns.Add("Radno Vreme");

            LoadData();
        }

        private void LoadData()
        {
            var result = _proizvodjacService.GetSviProizvodjaci();

            if (result.IsSuccess)
            {
                _proizvodjaci = result.Data!;
                lvProizvodjaci.Items.Clear();
                foreach (var proizvodjac in _proizvodjaci)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        proizvodjac.ID.ToString(),
                        proizvodjac.Naziv
                    });
                    lvProizvodjaci.Items.Add(item);
                }

                foreach (ColumnHeader column in lvProizvodjaci.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvProizvodjaci.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvProizvodjaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSaloni();
        }

        private void LoadSaloni()
        {
            int selectedIndex = lvProizvodjaci.SelectedItems.Count > 0 ? lvProizvodjaci.SelectedItems[0].Index : -1;
            if (selectedIndex == -1)
                return;

            int proizvodjacId = _proizvodjaci[selectedIndex].ID;

            var result = _proizvodjacService.GetSaloniZaProizvodjaca(proizvodjacId);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvSaloni.Items.Clear();
            foreach (var salon in result.Data!)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    salon.ID.ToString(),
                    salon.Naziv,
                    salon.Adresa,
                    salon.Grad,
                    salon.Drzava,
                    salon.KontaktTelefon,
                    salon.RadnoVreme
                });
                lvSaloni.Items.Add(item);
            }

            foreach (ColumnHeader column in lvSaloni.Columns)
            {
                column.Width = -2; // Auto size to fit content
            }

            lvSaloni.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddProizvodjac>();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lvProizvodjaci.SelectedItems.Count > 0 ? lvProizvodjaci.SelectedItems[0].Index : -1;

            if (selectedIndex == -1)
                return;

            int proizvodjacId = _proizvodjaci[selectedIndex].ID;

            var result = _proizvodjacService.Delete(proizvodjacId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Proizvođač uspešno obrisan.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvProizvodjaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite ponudu koju želite da izmenite.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvProizvodjaci.SelectedItems[0].Index;

            // Prosleđivanje DTO-a se i dalje može raditi ručno
            var form = ActivatorUtilities.CreateInstance<EditProizvodjac>(_serviceProvider, _proizvodjaci[selectedRowIndex]);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDodajSalonUPonudu_Click(object sender, EventArgs e)
        {
            if (lvProizvodjaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite proizvođača kome želite da dodate salone.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvProizvodjaci.SelectedItems[0].Index;

            // Prosleđivanje DTO-a se i dalje može raditi ručno
            var form = ActivatorUtilities.CreateInstance<AddSalonToNudi>(_serviceProvider, _proizvodjaci[selectedRowIndex]);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                // Osvezi listu vozila u promotivnoj ponudi
                LoadSaloni();
            }
        }

        private void btnIzbaciSalonIzPonudu_Click(object sender, EventArgs e)
        {
            if (lvProizvodjaci.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite proizvođača iz kog želite da izaberete salon.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lvSaloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite salon koji želite da izbacite.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedProizvodjacIndex = lvProizvodjaci.SelectedItems[0].Index;
            int proizvodjacId = _proizvodjaci[selectedProizvodjacIndex].ID;

            int salonId = int.Parse(lvSaloni.SelectedItems[0].SubItems[0].Text);

            var result = _proizvodjacService.DeleteSalonFromProizvodjac(proizvodjacId, salonId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Salon uspešno izbačen iz ponude.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSaloni();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
