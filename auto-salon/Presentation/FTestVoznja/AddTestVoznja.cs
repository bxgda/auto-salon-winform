using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using auto_salon.Presentation.FKupac;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FTestVoznja
{
    public partial class AddTestVoznja : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ITestVoznjaService _testVoznjaService;

        private VoziloTableDTO _vozilo;

        private readonly IKupacService _kupacService;
        private IList<FizickoLiceDTO> _fizickaLica = [];
        private IList<PravnoLiceDTO> _pravnaLica = [];

        private readonly ISalonService _salonService;
        private IList<ZaposleniDTO> _zaposleni = [];

        private ZaposleniDTO? _selectedZaposleni = null;
        private FizickoLiceDTO? _selectedFizickoLice = null;
        private PravnoLiceDTO? _selectedPravnoLice = null;

        public AddTestVoznja(VoziloTableDTO vozilo, IKupacService kupacService, ISalonService salonService, ITestVoznjaService testVoznjaService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            timePickerVreme.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            timePickerVreme.Format = DateTimePickerFormat.Custom;
            timePickerVreme.CustomFormat = "HH:mm";
            timePickerVreme.ShowUpDown = true;

            _vozilo = vozilo;
            _kupacService = kupacService;
            _salonService = salonService;

            this.Text = $"Test vožnja vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model} | {_vozilo.BrojSasije}";

            DefineColumnNamesForLists();

            LoadKupci();
            LoadZaposleni();
            _testVoznjaService = testVoznjaService;
            _serviceProvider = serviceProvider;
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
            _zaposleni = _zaposleni.Where(z => z.StatusZaposlenja == StatusZaposlenja.AKTIVAN).ToList();

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

        private void tcKupci_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pri prelasku izmedju tabova osiguraj da uvek samo jedan kupac može biti izabran
            if (tcKupci.SelectedTab == tpFizickoLice)
            {
                _selectedFizickoLice = null;
                lvFizickaLica.SelectedItems.Clear();
            }
            else if (tcKupci.SelectedTab == tpPravnoLice)
            {
                _selectedPravnoLice = null;
                lvPravnaLica.SelectedItems.Clear();
            }
        }

        private void lvZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count > 0)
            {
                var selectedItem = lvZaposleni.SelectedItems[0];
                _selectedZaposleni = _zaposleni.FirstOrDefault(p => p.JMBG == selectedItem.SubItems[0].Text);
            }
            else
            {
                _selectedZaposleni = null;
            }
        }

        private void lvFizickaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFizickaLica.SelectedItems.Count > 0)
            {
                var selectedItem = lvFizickaLica.SelectedItems[0];
                _selectedFizickoLice = _fizickaLica.FirstOrDefault(f => f.JMBG == selectedItem.SubItems[0].Text);
                _selectedPravnoLice = null; // Reset the other selection
            }
            else
            {
                _selectedFizickoLice = null;
            }
        }

        private void lvPravnaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPravnaLica.SelectedItems.Count > 0)
            {
                var selectedItem = lvPravnaLica.SelectedItems[0];
                _selectedPravnoLice = _pravnaLica.FirstOrDefault(p => p.PIB == selectedItem.SubItems[0].Text);
                _selectedFizickoLice = null; // Reset the other selection
            }
            else
            {
                _selectedPravnoLice = null;
            }
        }

        private void btnDodajKupca_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddKupac>();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadKupci();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedZaposleni == null)
            {
                MessageBox.Show("Molimo izaberite zaposlenog koji je prisustvovao test voznji.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedFizickoLice == null && _selectedPravnoLice == null)
            {
                MessageBox.Show("Molimo izaberite kupca.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_vozilo == null)
            {
                MessageBox.Show("Nije moguće sklopiti ugovor bez vozila.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TestVoznjaCreateDTO testVoznja = new TestVoznjaCreateDTO
            {
                Datum = dtpDatum.Value.Date.Date,
                Vreme = timePickerVreme.Value.ToString("HH:mm"),
                Ocena = nupOcena.Value,
                Zakljucak = rtbZakljucak.Text.Trim(),
                BrojSasije = _vozilo.BrojSasije,
                JmbgZaposlenog = _selectedZaposleni.JMBG,
                JmbgFizickogKupca = _selectedFizickoLice?.JMBG,
                PIBPravnogKupca = _selectedPravnoLice?.PIB
            };

            var result = _testVoznjaService.Add(testVoznja);

            if (result.IsSuccess)
            {
                MessageBox.Show("Test vožnja uspešno dodata.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show($"Greška pri dodavanju test vožnje: {result.ErrorMessage}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
