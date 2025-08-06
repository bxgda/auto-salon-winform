using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FServisnaStavka;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FVozilo
{
    public partial class VoziloUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IVoziloService _voziloService;
        private IList<VoziloTableDTO> _vozila = [];

        private string filter = "Sve";

        public VoziloUC(IServiceProvider serviceProvider, IVoziloService voziloService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbFilter.SelectedIndex = 0; // Set default filter to "Sve"
            _voziloService = voziloService;
            _serviceProvider = serviceProvider;

            // Define columns for ListView
            lvVozila.Columns.Add("Status");
            lvVozila.Columns.Add("Stanje");
            lvVozila.Columns.Add("Broj šasije");
            lvVozila.Columns.Add("Proizvođač");
            lvVozila.Columns.Add("Model");
            lvVozila.Columns.Add("Boja");
            lvVozila.Columns.Add("Broj vrata");
            lvVozila.Columns.Add("Tip goriva");
            lvVozila.Columns.Add("Snaga motora");
            lvVozila.Columns.Add("Kilometraža");
            lvVozila.Columns.Add("Godina proizvodnje");

            LoadData();
        }

        private void LoadData()
        {
            var result = _voziloService.GetAll();

            if (result.IsSuccess)
            {
                _vozila = result.Data!;
                InsertDataIntoListView();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertDataIntoListView()
        {
            lvVozila.Items.Clear();
            foreach (var vozilo in _vozila)
            {
                // Preskoci prodata vozila ako je filter "Dostupno"
                if (vozilo.JeProdato && filter == "Dostupno")
                    continue;

                // Preskoci nova vozila ako je filter "Polovno"
                if (!vozilo.JeProdato && filter == "Prodato")
                    continue;

                ListViewItem item = new ListViewItem(new string[]
                {
                    vozilo.JeProdato ? "Prodato" : "Dostupno",
                    vozilo.Stanje,
                    vozilo.BrojSasije,
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

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvVozila.Columns)
            {
                column.Width = -2; // Auto size to fit content
            }

            lvVozila.Refresh();
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
            string zaposleniId = _vozila[selectedRowIndex].BrojSasije;
            var result = _voziloService.Delete(zaposleniId);

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
                MessageBox.Show(
                    result.ErrorMessage,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null)
                return;

            filter = cbFilter.SelectedItem.ToString() ?? "Sve";

            InsertDataIntoListView();
        }
    }
}
