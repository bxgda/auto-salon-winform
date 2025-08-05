using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.Entities;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class AddZaposleni : Form
    {
        private readonly IZaposleniService _zaposleniService;
        private readonly SalonDTO _salon;

        public AddZaposleni(IZaposleniService zaposleniService, SalonDTO salon)
        {
            InitializeComponent();
            _zaposleniService = zaposleniService;
            _salon = salon;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Required fields
            string ime = tbxIme.Text.Trim();
            string prezime = tbxPrezime.Text.Trim();
            string jmbg = tbxJmbg.Text.Trim();
            string kontaktTelefon = tbxKontaktTelefon.Text.Trim();
            string pozicija = tbxPozicija.Text.Trim();
            DateTime datumZaposlenja;
            if (cbxUserCurrentDate.Checked)
            {
                datumZaposlenja = DateTime.Now;
            }
            else
            {
                datumZaposlenja = dtpDatumZaposlenja.Value;
            }
            string? uloga = cbxUloga.SelectedItem?.ToString();
            
            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(jmbg) ||
                string.IsNullOrWhiteSpace(kontaktTelefon) ||
                string.IsNullOrWhiteSpace(pozicija) ||
                string.IsNullOrWhiteSpace(uloga))
            {
                MessageBox.Show("Molimo popunite sva polja označena zvezdicom.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Uloga ulogaEnum = cbxItemToEnum(uloga);

            // Optional fields
            string email = tbxEmail.Text.Trim();
            string adresa = tbxAdresa.Text.Trim();

            ZaposleniDTO newZaposleni = new ZaposleniDTO
            {
                Ime = ime,
                Prezime = prezime,
                JMBG = jmbg,
                Pozicija = pozicija,
                DatumZaposlenja = datumZaposlenja,
                Uloga = ulogaEnum,
                KontaktTelefon = kontaktTelefon,
                Email = email,
                Adresa = adresa,
            };

            var result = _zaposleniService.Add(newZaposleni, _salon.ID);

            if (result.IsSuccess)
            {
                MessageBox.Show("Zaposleni uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Uloga cbxItemToEnum(string uloga)
        {
            return uloga switch
            {
                "Menadžer" => Uloga.MENADZER,
                "Prodavac" => Uloga.PRODAVAC,
                "Serviser" => Uloga.SERVISER,
                "Finansijski savetnik" => Uloga.FINANSIJSKI_SAVETNIK,
                _ => throw new NotImplementedException(),
            };
        } 

        private void cbxUserCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUserCurrentDate.Checked == true)
                dtpDatumZaposlenja.Enabled = false;
            else
                dtpDatumZaposlenja.Enabled = true;
        }
    }
}
