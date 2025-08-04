using auto_salon.App.DTOs;
using auto_salon.App.Services;

namespace auto_salon.Presentation.FSalon
{
    public partial class EditSalon : Form
    {
        private readonly ISalonService _salonService;
        private SalonTableDTO _salon;

        public EditSalon(ISalonService salonService, SalonTableDTO salon)
        {
            InitializeComponent();
            _salonService = salonService;
            _salon = salon;

            LoadUIWithData();
        }

        private void LoadUIWithData()
        {
            txtNaziv.Text = _salon.Naziv;
            txtAdresa.Text = _salon.Adresa;
            txtKontaktTelefon.Text = _salon.KontaktTelefon;
            txtDrzava.Text = _salon.Drzava;
            txtGrad.Text = _salon.Grad;

            if (!string.IsNullOrEmpty(_salon.RadnoVreme))
            {
                var radnoVremeParts = _salon.RadnoVreme.Split('-');
                if (radnoVremeParts.Length == 2)
                {
                    timePickerOd.Value = DateTime.ParseExact(radnoVremeParts[0], "HH:mm", null);
                    timePickerDo.Value = DateTime.ParseExact(radnoVremeParts[1], "HH:mm", null);
                }
            }

            cbxTip.SelectedItem = _salon.Tip;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                _salon.Naziv = txtNaziv.Text.Trim();
                _salon.Adresa = txtAdresa.Text.Trim();
                _salon.KontaktTelefon = txtKontaktTelefon.Text.Trim();
                _salon.Drzava = txtDrzava.Text.Trim();
                _salon.Grad = txtGrad.Text.Trim();
                _salon.RadnoVreme = $"{timePickerOd.Value:HH:mm}-{timePickerDo.Value:HH:mm}";
                
                var result = _salonService.Update(_salon);
                
                if (result.IsSuccess)
                {
                    MessageBox.Show("Salon uspešno ažuriran.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju salona: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
