using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FOcene
{
    public partial class OceniProdavca : Form
    {
        private readonly IKupacService _kupacService;
        private readonly IJeOcenioService _jeOcenioService;
        private ZaposleniDTO _prodavac;
        private IList<KupacDTO> _kupci = [];
        private int _selectedKupacId = -1;

        public OceniProdavca(ZaposleniDTO prodavac, IKupacService kupacService, IJeOcenioService jeOcenioService)
        {
            InitializeComponent();
            _prodavac = prodavac;
            _kupacService = kupacService;
            _jeOcenioService = jeOcenioService;

            this.Text = $"Ocenjivanje prodavca: {_prodavac.Ime} {_prodavac.Prezime}";
            DefineColumnNamesForList();
            LoadKupci();
        }

        private void LoadKupci()
        {
            var result = _kupacService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _kupci = result.Data!;

            lvFizickaLica.Items.Clear();
            lvPravnaLica.Items.Clear();

            foreach (var kupac in _kupci)
            {
                if (kupac.FizickoLice != null)
                {
                    var item = new ListViewItem(new[]
                    {
                            kupac.ID.ToString(),
                            kupac.FizickoLice.JMBG,
                            kupac.FizickoLice.Ime,
                            kupac.FizickoLice.Prezime,
                            kupac.FizickoLice.Email ?? string.Empty,
                            kupac.FizickoLice.KontaktTelefon,
                            kupac.FizickoLice.Adresa ?? string.Empty
                        });

                    lvFizickaLica.Items.Add(item);
                }
                else if (kupac.PravnoLice != null)
                {
                    var item = new ListViewItem(new[]
                    {
                            kupac.ID.ToString(),
                            kupac.PravnoLice.PIB,
                            kupac.PravnoLice.NazivFirme,
                            kupac.PravnoLice.Email,
                            kupac.PravnoLice.Telefon,
                            kupac.PravnoLice.Sediste,
                            kupac.PravnoLice.KontaktOsoba ?? string.Empty
                        });

                    lvPravnaLica.Items.Add(item);
                }
            }

            AutoResizeColumns(lvFizickaLica);
            AutoResizeColumns(lvPravnaLica);
        }

        private void DefineColumnNamesForList()
        {
            // lvFizickaLica
            lvFizickaLica.Columns.Add("ID");
            lvFizickaLica.Columns.Add("JMBG");
            lvFizickaLica.Columns.Add("Ime");
            lvFizickaLica.Columns.Add("Prezime");
            lvFizickaLica.Columns.Add("Email");
            lvFizickaLica.Columns.Add("Kontakt Telefon");
            lvFizickaLica.Columns.Add("Adresa");

            // lvPravnaLica
            lvPravnaLica.Columns.Add("ID");
            lvPravnaLica.Columns.Add("PIB");
            lvPravnaLica.Columns.Add("Naziv Firme");
            lvPravnaLica.Columns.Add("Email");
            lvPravnaLica.Columns.Add("Telefon");
            lvPravnaLica.Columns.Add("Sediste");
            lvPravnaLica.Columns.Add("Kontakt osoba");
        }

        private void AutoResizeColumns(ListView listView)
        {
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2; // Auto-size
            }

            listView.Refresh();
        }

        private void lvFizickaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvFizickaLica.SelectedIndices.Count > 0 ? lvFizickaLica.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            // Izvuci podatke iz prve kolone
            _selectedKupacId = int.Parse(lvFizickaLica.Items[selectedIndex].SubItems[0].Text);
        }

        private void lvPravnaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvPravnaLica.SelectedIndices.Count > 0 ? lvPravnaLica.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            // Izvuci podatke iz prve kolone 
            _selectedKupacId = int.Parse(lvPravnaLica.Items[selectedIndex].SubItems[0].Text);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_selectedKupacId == -1)
            {
                MessageBox.Show("Morate izabrati kupca.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var result = _jeOcenioService.Add(_prodavac.JMBG, _selectedKupacId, nupOcena.Value);

            if (result.IsSuccess)
            {
                MessageBox.Show("Uspešno ste ocenili prodavca.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
