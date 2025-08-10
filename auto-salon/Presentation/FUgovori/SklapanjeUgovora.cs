using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FUgovori
{
    public partial class SklapanjeUgovora : Form
    {
        private readonly IUgovoriService _ugovoriService;
        private readonly IZaposleniService _zaposleniService;
        private readonly IKupacService _kupacService;
        private readonly VoziloTableDTO _vozilo;

        public SklapanjeUgovora(VoziloTableDTO _vozilo, IUgovoriService ugovoriService, IZaposleniService zaposleniService, IKupacService kupacService)
        {
            InitializeComponent();
            this.Text = $"Prodaja vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model}";
            
            this._vozilo = _vozilo;
            _ugovoriService = ugovoriService;
            _zaposleniService = zaposleniService;
            _kupacService = kupacService;

            DefineColumnNamesForLists();

            LoadProdavci();
            LoadKupci();
        }

        private void DefineColumnNamesForLists()
        {
            // Prodavci ListView (lvProdavci)
            lvProdavci.Columns.Add("JMBG");
            lvProdavci.Columns.Add("Ime");
            lvProdavci.Columns.Add("Prezime");
            lvProdavci.Columns.Add("Uloga");
            lvProdavci.Columns.Add("Pozicija");
            lvProdavci.Columns.Add("Datum Zaposlenja");
            lvProdavci.Columns.Add("Kontakt Telefon");
            lvProdavci.Columns.Add("Email");
            lvProdavci.Columns.Add("Adresa");
            lvProdavci.Columns.Add("Datum Postavljenja");

            // lvFizickaLica
            lvFizickaLica.Columns.Add("JMBG");
            lvFizickaLica.Columns.Add("Ime");
            lvFizickaLica.Columns.Add("Prezime");
            lvFizickaLica.Columns.Add("Email");
            lvFizickaLica.Columns.Add("Kontakt Telefon");
            lvFizickaLica.Columns.Add("Adresa");

            // lvPravnaLica
            lvPravnaLica.Columns.Add("PIB");
            lvPravnaLica.Columns.Add("Naziv Firme");
            lvPravnaLica.Columns.Add("Email");
            lvPravnaLica.Columns.Add("Telefon");
            lvPravnaLica.Columns.Add("Sediste");
        }

        private void LoadProdavci()
        {
            var result = _zaposleniService.GetAllProdavciKojiMoguDaProdajuVozilo(_vozilo.BrojSasije);

            if (!result.IsSuccess)
            { 
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvProdavci.Items.Clear();

            foreach (var zaposleni in result.Data!)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        zaposleni.JMBG,
                        zaposleni.Ime,
                        zaposleni.Prezime,
                        zaposleni.Uloga.ToString(),
                        zaposleni.Pozicija,
                        zaposleni.DatumZaposlenja.ToShortDateString(),
                        zaposleni.KontaktTelefon,
                        zaposleni.Email ?? "",
                        zaposleni.Adresa ?? "",
                        zaposleni.DatumPostavljenja == default
                            ? ""
                            : zaposleni.DatumPostavljenja.ToShortDateString()
                });
                lvProdavci.Items.Add(item);
            }

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvProdavci.Columns)
            {
                column.Width = -2; // -2 means auto-size to content
            }

            lvProdavci.Refresh();
        }
        
        private void LoadKupci()
        {
            var result = _kupacService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvFizickaLica.Items.Clear();
            lvPravnaLica.Items.Clear();

            foreach (var kupac in result.Data!)
            {
                if (kupac.FizickoLice != null)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        kupac.FizickoLice.JMBG,
                        kupac.FizickoLice.Ime,
                        kupac.FizickoLice.Prezime,
                        kupac.FizickoLice.Email ?? "",
                        kupac.FizickoLice.KontaktTelefon ?? "",
                        kupac.FizickoLice.Adresa ?? ""
                    });
                    lvFizickaLica.Items.Add(item);
                }
                else if (kupac.PravnoLice != null)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        kupac.PravnoLice.PIB,
                        kupac.PravnoLice.NazivFirme,
                        kupac.PravnoLice.Email ?? "",
                        kupac.PravnoLice.Telefon ?? "",
                        kupac.PravnoLice.Sediste ?? ""
                    });

                    lvPravnaLica.Items.Add(item);
                }
            }

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvFizickaLica.Columns)
            {
                column.Width = -2; // -2 means auto-size to content
            }

            foreach (ColumnHeader column in lvPravnaLica.Columns)
            {
                column.Width = -2; // -2 means auto-size to content
            }

            lvFizickaLica.Refresh();
            lvPravnaLica.Refresh();
        }
    }

}
