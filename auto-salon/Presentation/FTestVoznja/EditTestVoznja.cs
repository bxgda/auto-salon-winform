using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FTestVoznja
{
    public partial class EditTestVoznja : Form
    {
        private readonly ITestVoznjaService _testVoznjaService;
        private readonly TestVoznjaTableDTO _testVoznja;

        public EditTestVoznja(ITestVoznjaService testVoznjaService, TestVoznjaTableDTO testVoznja)
        {
            InitializeComponent();
            _testVoznjaService = testVoznjaService;
            _testVoznja = testVoznja;

            LoadUIWithData();
        }

        private void LoadUIWithData()
        {
            nupOcena.Value = _testVoznja.Ocena;
            rtbZakljucak.Text = _testVoznja.Zakljucak;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbZakljucak.Text))
            {
                MessageBox.Show("Molimo unesite zaključak test vožnje.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rtbZakljucak.Focus();
                return;
            }

            _testVoznja.Ocena = (int)nupOcena.Value;
            _testVoznja.Zakljucak = rtbZakljucak.Text;

            var result = _testVoznjaService.Update(_testVoznja);

            if (result.IsSuccess)
            {
                MessageBox.Show("Test vožnja uspešno ažurirana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
