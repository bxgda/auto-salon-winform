using auto_salon.App.DTOs;
using auto_salon.App.Services;
using auto_salon.Entities;

namespace auto_salon.Presentation.FSalon
{
    public partial class AddSalon : Form
    {
        private readonly ISalonService _salonService;

        public AddSalon(ISalonService salonService)
        {
            InitializeComponent();
            _salonService = salonService;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string naziv = txtNaziv.Text.Trim();
            string adresa = txtAdresa.Text.Trim();
            string telefon = txtKontaktTelefon.Text.Trim();
            string drzava = txtDrzava.Text.Trim();
            string grad = txtGrad.Text.Trim();
            string radnoVreme = txtRadnoVreme.Text.Trim();
            string tip = cbxTip.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(naziv) ||
                string.IsNullOrWhiteSpace(adresa) ||
                string.IsNullOrWhiteSpace(telefon) ||
                string.IsNullOrWhiteSpace(drzava) ||
                string.IsNullOrWhiteSpace(grad) ||
                string.IsNullOrWhiteSpace(radnoVreme) ||
                string.IsNullOrWhiteSpace(tip))
            {
                MessageBox.Show("Molimo popunite sva polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SalonTableDTO newSalon = new SalonTableDTO
            {
                Naziv = naziv,
                Adresa = adresa,
                KontaktTelefon = telefon,
                Drzava = drzava,
                Grad = grad,
                RadnoVreme = radnoVreme,
                Tip = tip
            };

            var result = _salonService.Add(newSalon);

            if (result.IsSuccess)
            {
                MessageBox.Show("Salon uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
