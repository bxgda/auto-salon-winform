using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FSalon
{
    public partial class EditSalon : Form
    {
        private readonly ISalonService _salonService;
        private SalonDTO _salon;

        public EditSalon(SalonDTO salon, ISalonService salonService)
        {
            InitializeComponent();
            _salonService = salonService;
            _salon = salon;

            timePickerOd.Format = DateTimePickerFormat.Custom;
            timePickerOd.CustomFormat = "HH:mm";
            timePickerOd.ShowUpDown = true;

            timePickerDo.Format = DateTimePickerFormat.Custom;
            timePickerDo.CustomFormat = "HH:mm";
            timePickerDo.ShowUpDown = true;

            this.Text = $"Ažuriranje salona: {_salon.Naziv}";

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
                string naziv = txtNaziv.Text.Trim();
                string adresa = txtAdresa.Text.Trim();
                string telefon = txtKontaktTelefon.Text.Trim();
                string drzava = txtDrzava.Text.Trim();
                string grad = txtGrad.Text.Trim();
                string radnoVremeOd = timePickerOd.Value.ToString("HH:mm");
                string radnoVremeDo = timePickerDo.Value.ToString("HH:mm");
                string tip = cbxTip.SelectedItem?.ToString() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(naziv) ||
                    string.IsNullOrWhiteSpace(adresa) ||
                    string.IsNullOrWhiteSpace(telefon) ||
                    string.IsNullOrWhiteSpace(drzava) ||
                    string.IsNullOrWhiteSpace(grad) ||
                    string.IsNullOrWhiteSpace(radnoVremeOd) ||
                    string.IsNullOrWhiteSpace(radnoVremeDo) ||
                    string.IsNullOrWhiteSpace(tip))
                {
                    MessageBox.Show("Molimo popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
