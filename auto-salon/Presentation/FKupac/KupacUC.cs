using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FKupac
{
    public partial class KupacUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IKupacService _kupacService;

        private FizickoLiceDTO? _selectedFizickoLice = null;
        private PravnoLiceDTO? _selectedPravnoLice = null;

        private IList<FizickoLiceDTO> _fizickaLica = [];
        private IList<PravnoLiceDTO> _pravnaLica = [];

        public KupacUC(IServiceProvider serviceProvider, IKupacService kupacService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _kupacService = kupacService;
            _serviceProvider = serviceProvider;

            DefineColumnNamesForList();
            LoadKupci();
        }

        private void DefineColumnNamesForList()
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddKupac>();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadKupci();
            }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedFizickoLice == null && _selectedPravnoLice == null)
            {
                MessageBox.Show("Molimo izaberite fiziko ili pravno lice koje želite da izmenite.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kupacService = _serviceProvider.GetRequiredService<IKupacService>();

            var form = new EditKupac(_selectedFizickoLice, _selectedPravnoLice, kupacService);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadKupci();
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

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = tbxSearch.Text.Trim().ToLower();

            bool showAll = string.IsNullOrWhiteSpace(searchText) || searchText == "pretraga...";

            if (showAll)
            {
                PopulateListViewFizickaLica(_fizickaLica);
                PopulateListViewPravnaLica(_pravnaLica);
                return;
            }

            var filteredFizicka = _fizickaLica.Where(f =>
                f.JMBG.ToLower().Contains(searchText) ||
                f.Ime.ToLower().Contains(searchText) ||
                f.Prezime.ToLower().Contains(searchText) ||
                (f.Email?.ToLower().Contains(searchText) ?? false) ||
                (f.KontaktTelefon?.ToLower().Contains(searchText) ?? false) ||
                (f.Adresa?.ToLower().Contains(searchText) ?? false)).ToList();

            var filteredPravna = _pravnaLica.Where(p =>
                p.PIB.ToLower().Contains(searchText) ||
                p.NazivFirme.ToLower().Contains(searchText) ||
                (p.Email?.ToLower().Contains(searchText) ?? false) ||
                (p.Telefon?.ToLower().Contains(searchText) ?? false) ||
                (p.Sediste?.ToLower().Contains(searchText) ?? false) ||
                (p.KontaktOsoba?.ToLower().Contains(searchText) ?? false)).ToList();

            PopulateListViewFizickaLica(filteredFizicka);
            PopulateListViewPravnaLica(filteredPravna);
        }

        public void RemoveText(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "Pretraga...")
            {
                tbxSearch.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxSearch.Text))
                tbxSearch.Text = "Pretraga...";
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

    }
}
