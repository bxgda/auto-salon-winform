using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FOcene
{
    public partial class EditOcena : Form
    {
        private JeOcenioDTO _selectedOcena;
        private readonly IJeOcenioService _jeOcenioService;

        public EditOcena(JeOcenioDTO selectedOcena, IJeOcenioService jeOcenioService)
        {
            InitializeComponent();
            _selectedOcena = selectedOcena;
            _jeOcenioService = jeOcenioService;

            lblProdavac.Text = $"{_selectedOcena.ImeProdavca} {_selectedOcena.PrezimeProdavca}";
            // Ensure that the decimal value from _selectedOcena.Ocena is preserved when assigning to nupOcena.Value
            nupOcena.Value = decimal.Round(_selectedOcena.Ocena, nupOcena.DecimalPlaces);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var result = _jeOcenioService.Update(_selectedOcena.ID, nupOcena.Value);
            
            if (result.IsSuccess)
            {
                MessageBox.Show("Ocena uspešno ažurirana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show($"Greška pri ažuriranju ocene: {result.ErrorMessage}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
