using auto_salon.App.DTOs;
using auto_salon.App.Services;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FKupac
{
    public partial class EditKupac : Form
    {
        private readonly IKupacService _kupacService;
        private FizickoLiceDTO? _fizickoLiceDTO;
        private PravnoLiceDTO? _pravnoLiceDTO;

        public EditKupac(FizickoLiceDTO? fizickoLiceDTO, PravnoLiceDTO? pravnoLiceDTO, IKupacService kupacService)
        {
            InitializeComponent();

            _kupacService = kupacService;
            _fizickoLiceDTO = fizickoLiceDTO;
            _pravnoLiceDTO = pravnoLiceDTO;

            if (_fizickoLiceDTO == null && _pravnoLiceDTO == null)
            {
                throw new ArgumentException("At least one of the parameters must be provided.");
            }

            if (_fizickoLiceDTO != null)
            {
                this.Text = $"Izmena kupca - {_fizickoLiceDTO.Ime} {_fizickoLiceDTO.Prezime}";
                tbx1Kupac.MaxLength = 13; // za JMBG

                lbl1Kupac.Text = "JMBG *";
                lbl2Kupac.Text = "Ime *";
                lbl3Kupac.Text = "Prezime *";
                lbl4Kupac.Text = "Email";
                lbl5Kupac.Text = "Kontakt telefon *";
                lbl6Kupac.Text = "Adresa *";

                tbx1Kupac.Text = _fizickoLiceDTO.JMBG;
                tbx2Kupac.Text = _fizickoLiceDTO.Ime;
                tbx3Kupac.Text = _fizickoLiceDTO.Prezime;
                tbx4Kupac.Text = _fizickoLiceDTO.Email ?? string.Empty;
                tbx5Kupac.Text = _fizickoLiceDTO.KontaktTelefon;
                tbx6Kupac.Text = _fizickoLiceDTO.Adresa ?? string.Empty;
            }
            else if (_pravnoLiceDTO != null)
            {
                this.Text = $"Izmena kupca - { _pravnoLiceDTO.NazivFirme}";
                tbx1Kupac.MaxLength = 9; // za PIB

                lbl1Kupac.Text = "PIB *";
                lbl2Kupac.Text = "Naziv firme *";
                lbl3Kupac.Text = "Email *";
                lbl4Kupac.Text = "Telefon *";
                lbl5Kupac.Text = "Sedište *";
                lbl6Kupac.Text = "Kontakt osoba *";

                tbx1Kupac.Text = _pravnoLiceDTO.PIB;
                tbx2Kupac.Text = _pravnoLiceDTO.NazivFirme;
                tbx3Kupac.Text = _pravnoLiceDTO.Email ?? string.Empty;
                tbx4Kupac.Text = _pravnoLiceDTO.Telefon;
                tbx5Kupac.Text = _pravnoLiceDTO.Sediste ?? string.Empty;
                tbx6Kupac.Text = _pravnoLiceDTO.KontaktOsoba ?? string.Empty;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_fizickoLiceDTO == null && _pravnoLiceDTO == null)
            {
                MessageBox.Show("Nije moguće izmeniti kupca", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServiceResult<bool> result;

            if (_fizickoLiceDTO != null)
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

                FizickoLiceDTO fizickoLiceDto = new FizickoLiceDTO
                {
                    JMBG = tbx1Kupac.Text,
                    Ime = tbx2Kupac.Text,
                    Prezime = tbx3Kupac.Text,
                    Email = tbx4Kupac.Text,
                    KontaktTelefon = tbx5Kupac.Text,
                    Adresa = tbx6Kupac.Text
                };

                result = _kupacService.UpdateFizickoLice(fizickoLiceDto);
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

                PravnoLiceDTO pravnoLice = new PravnoLiceDTO
                {
                    PIB = tbx1Kupac.Text,
                    NazivFirme = tbx2Kupac.Text,
                    Email = tbx3Kupac.Text,
                    Telefon = tbx4Kupac.Text,
                    Sediste = tbx5Kupac.Text,
                    KontaktOsoba = tbx6Kupac.Text
                };

                result = _kupacService.UpdatePravnoLice(pravnoLice);
            }

            if (result.IsSuccess)
            {
                MessageBox.Show("Kupac uspešno izmenjen.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
