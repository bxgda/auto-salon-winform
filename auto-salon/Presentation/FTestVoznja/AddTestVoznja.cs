using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FTestVoznja
{
    public partial class AddTestVoznja : Form
    {
        private VoziloTableDTO _vozilo;

        private readonly IKupacService _kupacService;
        private IList<FizickoLiceDTO> _fizickaLica = [];
        private IList<PravnoLiceDTO> _pravnaLica = [];

        private readonly ISalonService _salonService;
        private IList<ZaposleniDTO> _zaposleni = [];

        public AddTestVoznja(VoziloTableDTO vozilo, IKupacService kupacService, ISalonService salonService)
        {
            InitializeComponent();

            _vozilo = vozilo;
            _kupacService = kupacService;
            _salonService = salonService;

            this.Text = $"Test vožnja vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model} | {_vozilo.BrojSasije}";

            DefineColumnNamesForLists();
            LoadKupci();
            LoadZaposleni();
        }

        private void DefineColumnNamesForLists()
        {
            // Prodavci ListView (lvProdavci)
            lvZaposleni.Columns.Add("JMBG");
            lvZaposleni.Columns.Add("Ime");
            lvZaposleni.Columns.Add("Prezime");
            lvZaposleni.Columns.Add("Uloga");
            lvZaposleni.Columns.Add("Pozicija");
            lvZaposleni.Columns.Add("Datum Zaposlenja");
            lvZaposleni.Columns.Add("Kontakt Telefon");
            lvZaposleni.Columns.Add("Email");
            lvZaposleni.Columns.Add("Adresa");
            lvZaposleni.Columns.Add("Datum Postavljenja");

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
            lvPravnaLica.Columns.Add("Kontakt osoba");
        }

        private void LoadKupci()
        {
            var result = _kupacService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _fizickaLica = result.Data!
                .Where(k => k.FizickoLice != null)
                .Select(k => k.FizickoLice!)
                .ToList();

            _pravnaLica = result.Data!
                .Where(k => k.PravnoLice != null)
                .Select(k => k.PravnoLice!)
                .ToList();

            PopulateListViewFizickaLica(_fizickaLica);
            PopulateListViewPravnaLica(_pravnaLica);
        }

        private void LoadZaposleni()
        {
            var result = _salonService.GetZaposleniSalona(_vozilo.IdSalona);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _zaposleni = result.Data!;

            PopulateListViewZaposleni(_zaposleni);
        }

        private void PopulateListViewFizickaLica(IEnumerable<FizickoLiceDTO> fizickaLica)
        {
            lvFizickaLica.BeginUpdate();
            lvFizickaLica.Items.Clear();

            foreach (var f in fizickaLica)
            {
                var item = new ListViewItem(new[]
                {
                    f.JMBG,
                    f.Ime,
                    f.Prezime,
                    f.Email ?? "",
                    f.KontaktTelefon ?? "",
                    f.Adresa ?? ""
                });

                lvFizickaLica.Items.Add(item);
            }

            AutoResizeColumns(lvFizickaLica);
            lvFizickaLica.EndUpdate();
        }

        private void PopulateListViewPravnaLica(IEnumerable<PravnoLiceDTO> pravnaLica)
        {
            lvPravnaLica.BeginUpdate();
            lvPravnaLica.Items.Clear();

            foreach (var p in pravnaLica)
            {
                var item = new ListViewItem(new[]
                {
                    p.PIB,
                    p.NazivFirme,
                    p.Email ?? "",
                    p.Telefon ?? "",
                    p.Sediste ?? "",
                    p.KontaktOsoba ?? ""
                });

                lvPravnaLica.Items.Add(item);
            }

            AutoResizeColumns(lvPravnaLica);
            lvPravnaLica.EndUpdate();
        }

        private void PopulateListViewZaposleni(IEnumerable<ZaposleniDTO> zaposleni)
        {
            lvZaposleni.BeginUpdate();
            lvZaposleni.Items.Clear();

            foreach (var p in zaposleni)
            {
                var item = new ListViewItem(new[]
                {
                    p.JMBG,
                    p.Ime,
                    p.Prezime,
                    p.Uloga.ToString(),
                    p.Pozicija,
                    p.DatumZaposlenja.ToShortDateString(),
                    p.KontaktTelefon ?? "",
                    p.Email ?? "",
                    p.Adresa ?? "",
                    p.DatumPostavljenja == default
                        ? ""
                        : p.DatumPostavljenja.ToShortDateString()
                });

                lvZaposleni.Items.Add(item);
            }

            AutoResizeColumns(lvZaposleni);
            lvZaposleni.EndUpdate();
        }

        private void AutoResizeColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2; // Auto-size
            }
        }
    }
}
