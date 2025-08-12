using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FKupac
{
    public partial class AddKupac : Form
    {
        private readonly IKupacService _kupacService;

        public AddKupac(IKupacService kupacService)
        {
            InitializeComponent();
            _kupacService = kupacService;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            KupacDTO kupacDTO = new KupacDTO();

            // Validiraj da je izabran tip kupca
            if (!rbFizickoLice.Checked && !rbPravnoLice.Checked)
            {
                MessageBox.Show("Izaberite tip kupca.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rbFizickoLice.Checked)
            {
                // Validiraj fizicko lice input
                if (string.IsNullOrWhiteSpace(tbx1Kupac.Text) || tbx1Kupac.Text.Length != 13 ||
                    string.IsNullOrEmpty(tbx2Kupac.Text) ||
                    string.IsNullOrEmpty(tbx3Kupac.Text) ||
                    string.IsNullOrEmpty(tbx5Kupac.Text))
                {
                    MessageBox.Show("Popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                kupacDTO.FizickoLice = new FizickoLiceDTO
                {
                    JMBG = tbx1Kupac.Text,
                    Ime = tbx2Kupac.Text,
                    Prezime = tbx3Kupac.Text,
                    Email = tbx4Kupac.Text,
                    KontaktTelefon = tbx5Kupac.Text,
                    Adresa = tbx6Kupac.Text
                };
            }
            else
            {
                // Validiraj pravno lice input (sva polja su obavezna)
                if (string.IsNullOrWhiteSpace(tbx1Kupac.Text) || tbx1Kupac.Text.Length != 9 ||
                    string.IsNullOrEmpty(tbx2Kupac.Text) ||
                    string.IsNullOrEmpty(tbx3Kupac.Text) ||
                    string.IsNullOrEmpty(tbx4Kupac.Text) ||
                    string.IsNullOrEmpty(tbx5Kupac.Text) ||
                    string.IsNullOrEmpty(tbx6Kupac.Text))
                {
                    MessageBox.Show("Sva polja moraju biti popunjena.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                kupacDTO.PravnoLice = new PravnoLiceDTO
                {
                    PIB = tbx1Kupac.Text,
                    NazivFirme = tbx2Kupac.Text,
                    Email = tbx3Kupac.Text,
                    Telefon = tbx4Kupac.Text,
                    Sediste = tbx5Kupac.Text,
                    KontaktOsoba = tbx6Kupac.Text
                };
            }

            var result = _kupacService.AddKupac(kupacDTO);

            if (result.IsSuccess)
            {
                MessageBox.Show("Kupac uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFizickoLice.Checked)
            {
                tbx1Kupac.MaxLength = 13; // za JMBG

                lbl1Kupac.Text = "JMBG *";
                lbl2Kupac.Text = "Ime *";
                lbl3Kupac.Text = "Prezime *" ;
                lbl4Kupac.Text = "Email";
                lbl5Kupac.Text = "Kontakt telefon *";
                lbl6Kupac.Text = "Adresa *";
            }
            else
            {
                tbx1Kupac.MaxLength = 9; // za PIB

                lbl1Kupac.Text = "PIB *";
                lbl2Kupac.Text = "Naziv firme *";
                lbl3Kupac.Text = "Email *";
                lbl4Kupac.Text = "Telefon *";
                lbl5Kupac.Text = "Sedište *";
                lbl6Kupac.Text = "Kontakt osoba *";
            }

        }
    }
}
