using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

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

            if (fizickoLiceDTO == null && pravnoLiceDTO == null)
            {
                throw new ArgumentException("At least one of the parameters must be provided.");
            }
            if (fizickoLiceDTO != null)
            {
                _fizickoLiceDTO = fizickoLiceDTO;

                tbx1Kupac.MaxLength = 13; // za JMBG

                lbl1Kupac.Text = "JMBG *";
                lbl2Kupac.Text = "Ime *";
                lbl3Kupac.Text = "Prezime *";
                lbl4Kupac.Text = "Email";
                lbl5Kupac.Text = "Kontakt telefon *";
                lbl6Kupac.Text = "Adresa *";
            }
            else if (pravnoLiceDTO != null)
            {
                _pravnoLiceDTO = pravnoLiceDTO;

                tbx1Kupac.MaxLength = 9; // za PIB

                lbl1Kupac.Text = "PIB *";
                lbl2Kupac.Text = "Naziv firme *";
                lbl3Kupac.Text = "Email *";
                lbl4Kupac.Text = "Telefon *";
                lbl5Kupac.Text = "Sedište *";
                lbl6Kupac.Text = "Kontakt osoba *";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
