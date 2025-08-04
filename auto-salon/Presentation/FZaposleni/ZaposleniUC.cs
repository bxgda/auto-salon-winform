using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniUC : UserControl
    {
        private readonly IZaposleniService _zaposleniService;
        private IList<ZaposleniDTO> _zaposleni = [];

        public ZaposleniUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _zaposleniService = new ZaposleniService();
            LoadData();
        }

        private void LoadData()
        {
            var result = _zaposleniService.GetAll();

            if (result.IsSuccess)
            {
                _zaposleni = result.Data!;
                dgvZaposleni.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite zaposlenog koji želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = dgvZaposleni.SelectedRows[0].Index;
            string zaposleniId = _zaposleni[selectedRowIndex].JMBG;
            var result = _zaposleniService.Delete(zaposleniId);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show(
                    "Zaposleni je uspešno obrisan.",
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
