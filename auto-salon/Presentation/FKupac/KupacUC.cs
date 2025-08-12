using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FSalon;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FKupac
{
    public partial class KupacUC : UserControl
    {
        private FizickoLiceDTO? _selectedFizickoLice = null;
        private PravnoLiceDTO? _selectedPravnoLice = null;
        private readonly IServiceProvider _serviceProvider;
        private readonly IKupacService _kupacService;
        private IList<FizickoLiceDTO> _fizickaLica = [];
        private IList<PravnoLiceDTO> _pravnaLica = [];

        public KupacUC(IKupacService kupacService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
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

            _fizickaLica = result.Data!.Where(k => k.FizickoLice != null).Select(k => k.FizickoLice!).ToList();
            _pravnaLica = result.Data!.Where(k => k.PravnoLice != null).Select(k => k.PravnoLice!).ToList();

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

            var form = ActivatorUtilities.CreateInstance<EditKupac>(_serviceProvider, _selectedFizickoLice!, _selectedPravnoLice!);
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
    }
}
