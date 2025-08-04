using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FVozilo
{
    public partial class VoziloUC : UserControl
    {
        private readonly IVoziloService _voziloService;
        private IList<VoziloTableDTO> _vozila = [];

        public VoziloUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _voziloService = new VoziloService();
            LoadData();
        }

        private void LoadData()
        {
            var result = _voziloService.GetAll();

            if (result.IsSuccess)
            {
                _vozila = result.Data!;
                dgvVozila.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVozila.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite vozilo koje želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = dgvVozila.SelectedRows[0].Index;
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
