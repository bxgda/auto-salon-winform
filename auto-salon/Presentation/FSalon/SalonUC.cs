using auto_salon.App.DTOs;
using auto_salon.App.Services;

namespace auto_salon.Presentation.FSalon
{
    public partial class SalonUC : UserControl
    {
        private readonly ISalonService _salonService;
        private IList<SalonTableDTO> _saloni = [];

        public SalonUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _salonService = new SalonService();
            LoadData();
        }

        private void LoadData()
        {
            var result = _salonService.GetAll();

            if (result.IsSuccess)
            {
                _saloni = result.Data!;
                dgvSaloni.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        # region Event Handlers

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSaloni.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite salon koji želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = dgvSaloni.SelectedRows[0].Index;

            if (selectedRowIndex < 0 || selectedRowIndex >= dgvSaloni.Rows.Count)
            {
                MessageBox.Show(
                    "Izabrani red nije validan.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int salonId = _saloni[selectedRowIndex].ID;
            var result = _salonService.Delete(salonId);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show(
                    "Salon je uspešno obrisan.",
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

        #endregion
    }
}
