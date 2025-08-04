using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniSalona : Form
    {
        private readonly IZaposleniService _zaposleniService;
        private readonly SalonDTO _salon;
        private IList<ZaposleniDTO> _zapos = [];

        public ZaposleniSalona(SalonDTO salon)
        {
            InitializeComponent();
            _zaposleniService = new ZaposleniService();
            _salon = salon;

            this.Text = $"Zaposleni salona: {_salon.Naziv}";

            FetchZaposleni();
        }

        private void FetchZaposleni()
        {
            var result = _zaposleniService.GetBySalonId(_salon.ID);
            if (result.IsSuccess)
            {
                _zapos = result.Data!;
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
                    "Molimo izaberite zaposlenog kojeg želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = dgvZaposleni.SelectedRows[0].Index;
            string jmbg = _zapos[selectedRowIndex].JMBG;
            
            var result = _zaposleniService.Delete(jmbg);

            if (result.IsSuccess)
            {
                FetchZaposleni();
                MessageBox.Show(
                    "Zaposleni je uspešno obrisan.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
