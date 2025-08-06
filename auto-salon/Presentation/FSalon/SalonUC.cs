using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FZaposleni;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FSalon
{
    public partial class SalonUC : UserControl
    {
        private readonly ISalonService _salonService;
        private readonly IServiceProvider _serviceProvider;
        private IList<SalonDTO> _saloni = [];

        public SalonUC(IServiceProvider serviceProvider, ISalonService salonService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _serviceProvider = serviceProvider;
            _salonService = salonService;

            // Define columns for ListView
            lvSaloni.Columns.Add("ID");
            lvSaloni.Columns.Add("Tip");
            lvSaloni.Columns.Add("Naziv");
            lvSaloni.Columns.Add("Adresa");
            lvSaloni.Columns.Add("Kontakt Telefon");
            lvSaloni.Columns.Add("Radno Vreme");
            lvSaloni.Columns.Add("Država");
            lvSaloni.Columns.Add("Grad");
            lvSaloni.Columns.Add("Broj Zaposlenih");

            LoadData();
        }

        private void LoadData()
        {
            var result = _salonService.GetAll();

            if (result.IsSuccess)
            {
                _saloni = result.Data!;

                lvSaloni.Items.Clear();
                foreach (var salon in _saloni)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        salon.ID.ToString(),
                        salon.Tip.ToString(),
                        salon.Naziv,
                        salon.Adresa,
                        salon.KontaktTelefon,
                        salon.RadnoVreme,
                        salon.Drzava,
                        salon.Grad,
                        salon.BrojZaposlenih.ToString()
                    });
                    lvSaloni.Items.Add(item);
                }

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvSaloni.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvSaloni.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Osnovni podaci

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvSaloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite salon koji želite da obrišete.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvSaloni.SelectedItems[0].Index;
            int salonId = _saloni[selectedRowIndex].ID;
            var result = _salonService.Delete(salonId);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show("Salon je uspešno obrisan.",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage,
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddSalon>();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvSaloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite salon koji želite da izmenite.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvSaloni.SelectedItems[0].Index;

            // Prosleđivanje DTO-a se i dalje može raditi ručno
            var form = ActivatorUtilities.CreateInstance<EditSalon>(_serviceProvider, _saloni[selectedRowIndex]);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        #endregion

        #region Zaposleni

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            if (lvSaloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite salon za koji želite da vidite zaposlene.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvSaloni.SelectedItems[0].Index;

            var form = ActivatorUtilities.CreateInstance<ZaposleniSalona>(_serviceProvider, _saloni[selectedRowIndex]);
            form.ShowDialog();

            LoadData(); // Ako je obrisan zaposleni da osvezi prikaz broja zaposlenih u poslednjoj koloni
        }

        #endregion

        #region Vozila

        private void btnVozila_Click(object sender, EventArgs e)
        {
            if (lvSaloni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite salon za koji želite da vidite vozila.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvSaloni.SelectedItems[0].Index;

            var form = ActivatorUtilities.CreateInstance<VozilaSalona>(_serviceProvider, _saloni[selectedRowIndex]);
            form.ShowDialog();
        }

        #endregion
    }
}
