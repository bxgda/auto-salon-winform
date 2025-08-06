using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FVozilo
{
    public partial class VoziloUC : UserControl
    {
        private readonly IVoziloService _voziloService;
        private IList<VoziloTableDTO> _vozila = [];

        public VoziloUC(IVoziloService voziloService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _voziloService = voziloService;

            // Define columns for ListView
            lvVozila.Columns.Add("Stanje");
            lvVozila.Columns.Add("Broj šasije");
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

                lvVozila.Items.Clear();
                foreach (var vozilo in _vozila)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        vozilo.Stanje,
                        vozilo.BrojSasije,
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
    }
}
