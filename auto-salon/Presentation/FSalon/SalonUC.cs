using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FSalon
{
    public partial class SalonUC : UserControl
    {
        private readonly ISalonService _salonService;
        private IList<SalonDTO> _saloni = [];

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new AddSalon(_salonService).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSaloni.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite salon koji želite da izmenite.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = dgvSaloni.SelectedRows[0].Index;

            DialogResult dialogResult = new EditSalon(_salonService, _saloni[selectedRowIndex]).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
