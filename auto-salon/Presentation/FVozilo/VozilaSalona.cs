using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FServisnaStavka;
using auto_salon.Presentation.FUgovori;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FVozilo
{
    public partial class VozilaSalona : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IVoziloService _vozilaService;
        private readonly SalonDTO _salon;
        private IList<VoziloTableDTO> _vozila = [];

        public VozilaSalona(SalonDTO salon, IVoziloService voziloService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _vozilaService = voziloService;
            _salon = salon;

            // Define columns for ListView
            lvVozila.Columns.Add("Status");
            lvVozila.Columns.Add("Stanje");
            lvVozila.Columns.Add("Broj šasije");
            lvVozila.Columns.Add("Cena");
            lvVozila.Columns.Add("Proizvođač");
            lvVozila.Columns.Add("Model");
            lvVozila.Columns.Add("Boja");
            lvVozila.Columns.Add("Broj vrata");
            lvVozila.Columns.Add("Tip goriva");
            lvVozila.Columns.Add("Snaga motora");
            lvVozila.Columns.Add("Kilometraža");
            lvVozila.Columns.Add("Godina proizvodnje");

            this.Text = $"Vozila salona: {_salon.Naziv}";

            LoadData();
        }

        private void LoadData()
        {
            var result = _vozilaService.GetBySalonId(_salon.ID);
            if (result.IsSuccess)
            {
                _vozila = result.Data!;
                lvVozila.Items.Clear();

                foreach (var vozilo in _vozila)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        vozilo.JeProdato ? "Prodato" : "Dostupno",
                        vozilo.Stanje,
                        vozilo.BrojSasije,
                        vozilo.Cena.ToString("C2"),
                        vozilo.NazivProizvodjaca ?? "N/A",
                        vozilo.Model,
                        vozilo.Boja,
                        vozilo.BrojVrata.ToString(),
                        vozilo.TipGoriva.ToString(),
                        vozilo.SnagaMotora.ToString(),
                        vozilo.Kilometraza.ToString(),
                        vozilo.GodinaProizvodnje.ToString()
                    });
                    lvVozila.Items.Add(item);
                }

                foreach (ColumnHeader column in lvVozila.Columns)
                {
                    column.Width = -2; // Auto-size columns based on content
                }

                lvVozila.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite vozilo koje želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = lvVozila.SelectedItems[0].Index;
            string brojSasije = _vozila[selectedRowIndex].BrojSasije;

            var result = _vozilaService.Delete(brojSasije);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show(
                    "Vozilo je uspešno obrisano.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kreiranje AddVozilo forme preko DI + prosleđivanje salona
            var form = ActivatorUtilities.CreateInstance<AddVozilo>(_serviceProvider, _salon);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnProdaj_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite vozilo koje želite da prodate.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Broj sasije je u trecoj koloni (indeks 2)
            string brojSasije = lvVozila.SelectedItems[0].SubItems[2].Text;

            // Pronadji vozilo u _vozila po BrojSasije
            var vozilo = _vozila.FirstOrDefault(v => v.BrojSasije == brojSasije);
            if (vozilo == null)
            {
                MessageBox.Show(
                    "Došlo je do greške pri pronalaženju vozila.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (vozilo.JeProdato)
            {
                MessageBox.Show("Vozilo je već prodato.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var form = ActivatorUtilities.CreateInstance<SklapanjeUgovora>(_serviceProvider, vozilo);
            form.ShowDialog();

            LoadData();
        }

        private void btnServisnaIstorija_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite vozilo za koje želite da vidi servisnu istoriju",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvVozila.SelectedItems[0].Index;

            if (_vozila[selectedRowIndex].Stanje == "Novo")
            {
                MessageBox.Show("Vozilo je novo i nema servisnu istoriju.",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var form = ActivatorUtilities.CreateInstance<ServisnaIstorijaVozila>(_serviceProvider, _vozila[selectedRowIndex]);
            form.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvVozila.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite vozilo koje želite da izmenite",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvVozila.SelectedItems[0].Index;
            VoziloTableDTO vozilo = _vozila[selectedRowIndex];

            if (vozilo.JeProdato)
            {
                MessageBox.Show("Vozilo je već prodato i ne može se menjati.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prosleđivanje DTO-a se i dalje može raditi ručno
            var form = ActivatorUtilities.CreateInstance<EditVozilo>(_serviceProvider, vozilo);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
