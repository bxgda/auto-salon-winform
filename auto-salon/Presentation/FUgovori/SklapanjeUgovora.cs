using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;
using auto_salon.Presentation.FKupac;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FUgovori
{
    public partial class SklapanjeUgovora : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUgovoriService _ugovoriService;
        private readonly IZaposleniService _zaposleniService;
        private readonly IKupacService _kupacService;
        private readonly VoziloTableDTO _vozilo;
        private IList<ZaposleniDTO> _prodavci = [];
        private IList<FizickoLiceDTO> _fizickaLica = [];
        private IList<PravnoLiceDTO> _pravnaLica = [];
        private ZaposleniDTO? _selectedProdavac = null;
        private FizickoLiceDTO? _selectedFizickoLice = null;
        private PravnoLiceDTO? _selectedPravnoLice = null;

        public SklapanjeUgovora(VoziloTableDTO _vozilo, IServiceProvider serviceProvider, IUgovoriService ugovoriService, IZaposleniService zaposleniService, IKupacService kupacService)
        {
            InitializeComponent();
            this.Text = $"Prodaja vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model}";

            this._vozilo = _vozilo;
            _serviceProvider = serviceProvider;
            _ugovoriService = ugovoriService;
            _zaposleniService = zaposleniService;
            _kupacService = kupacService;

            lblCena.Text = _vozilo.Cena.ToString("C2");

            DefineColumnNamesForLists();

            LoadProdavci();
            LoadKupci();
            InsertIntoNacinPlacanjaComboBox();
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
            lvPravnaLica.Columns.Add("Kontakt osoba");
        }

        private void LoadProdavci()
        {
            var result = _zaposleniService.GetAllProdavciKojiMoguDaProdajuVozilo(_vozilo.BrojSasije);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _prodavci = result.Data!;

            PopulateListViewProdavci(_prodavci);
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

        private void AutoResizeColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2; // Auto-size
            }
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

        private void PopulateListViewProdavci(IEnumerable<ZaposleniDTO> prodavci)
        {
            lvProdavci.BeginUpdate();
            lvProdavci.Items.Clear();

            foreach (var p in prodavci)
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
                lvProdavci.Items.Add(item);
            }

            AutoResizeColumns(lvProdavci);
            lvProdavci.EndUpdate();
        }

        private void InsertIntoNacinPlacanjaComboBox()
        {
            cbNacinPlacanja.Items.Clear();

            List<NacinPlacanjaItem> nacinPlacanjaItems = new List<NacinPlacanjaItem>
            {
                new NacinPlacanjaItem("Gotovina", NacinPlacanja.GOTOVINA),
                new NacinPlacanjaItem("Kartica", NacinPlacanja.KREDIT),
                new NacinPlacanjaItem("Lizing", NacinPlacanja.LIZING)
            };

            cbNacinPlacanja.DataSource = nacinPlacanjaItems;
            cbNacinPlacanja.DisplayMember = "DisplayName";
            cbNacinPlacanja.ValueMember = "Value";
        }

        #region Event Handlers

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Proveri da li su svi potrebni podaci uneti
            if (_selectedProdavac == null)
            {
                MessageBox.Show("Molimo izaberite prodavca.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (cbNacinPlacanja.SelectedIndex == -1 || cbNacinPlacanja.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite način plaćanja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UgovorCreateDTO ugovor = new UgovorCreateDTO
            {
                BrojSasije = _vozilo.BrojSasije,
                JmbgProdavca = _selectedProdavac.JMBG,
                JmbgFizickogKupca = _selectedFizickoLice?.JMBG,
                PIBPravnogKupca = _selectedPravnoLice?.PIB,
                NacinPlacanja = ((NacinPlacanjaItem)cbNacinPlacanja.SelectedItem).Value,
                DodatnaOprema = tbxDodatnaOprema.Text.Trim(),
                KonacnaOcena = nupKonacnaOcena.Value,
                OcenaProdavca = nupOcenaProdavca.Value
            };

            var result = _ugovoriService.Create(ugovor);
            if (result.IsSuccess)
            {
                MessageBox.Show("Ugovor uspešno sklopljen!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Postavi rezultat dijaloga na OK
                this.Close(); // Zatvori formu
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lvProdavci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProdavci.SelectedItems.Count > 0)
            {
                var selectedItem = lvProdavci.SelectedItems[0];
                _selectedProdavac = _prodavci.FirstOrDefault(p => p.JMBG == selectedItem.SubItems[0].Text);
            }
            else
            {
                _selectedProdavac = null;
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

        #endregion
    }

    class NacinPlacanjaItem
    {
        public string DisplayName { get; set; }
        public NacinPlacanja Value { get; set; }

        public NacinPlacanjaItem(string displayName, NacinPlacanja value)
        {
            DisplayName = displayName;
            Value = value;
        }
        public override string ToString()
        {
            return DisplayName;
        }
    }

}
