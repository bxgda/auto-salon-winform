using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FOcene
{
    public partial class OceneUC : UserControl
    {
        public readonly IJeOcenioService _jeOcenioService;
        private IList<JeOcenioDTO> _ocene = [];
        private JeOcenioDTO _selectedOcena = new();

        public OceneUC(IJeOcenioService jeOcenioService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _jeOcenioService = jeOcenioService;

            DefineColumnNamesForList();
            LoadOcene();
        }

        private void DefineColumnNamesForList()
        {
            // lvFizickaLica
            lvFizickaLica.Columns.Add("ID Kupca");
            lvFizickaLica.Columns.Add("Ime");
            lvFizickaLica.Columns.Add("Prezime");
            lvFizickaLica.Columns.Add("Ocena");
            lvFizickaLica.Columns.Add("Ime Prodavca");
            lvFizickaLica.Columns.Add("Prezime Prodavca");

            // lvPravnaLica
            lvPravnaLica.Columns.Add("ID Kupca");
            lvPravnaLica.Columns.Add("PIB");
            lvPravnaLica.Columns.Add("Naziv Firme");
            lvPravnaLica.Columns.Add("Ocena");
            lvPravnaLica.Columns.Add("Ime Prodavca");
            lvPravnaLica.Columns.Add("Prezime Prodavca");
        }

        private void LoadOcene()
        {
            var result = _jeOcenioService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ocene = result.Data!;

            lvFizickaLica.Items.Clear();
            lvPravnaLica.Items.Clear();

            foreach (var ocena in _ocene)
            {
                if (ocena.TipKupca == "Fizicko lice")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        ocena.IdKupca.ToString(),
                        ocena.ImeKupca!,
                        ocena.PrezimeKupca!,
                        ocena.Ocena.ToString(),
                        ocena.ImeProdavca,
                        ocena.PrezimeProdavca
                    });

                    lvFizickaLica.Items.Add(item);
                }
                else if (ocena.TipKupca == "Pravno lice")
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        ocena.IdKupca.ToString(),
                        ocena.PIBKupca!,
                        ocena.NazivFirmeKupca!,
                        ocena.Ocena.ToString(),
                        ocena.ImeProdavca,
                        ocena.PrezimeProdavca
                    });

                    lvPravnaLica.Items.Add(item);
                }
            }

            foreach (ColumnHeader column in lvFizickaLica.Columns)
            {
                column.Width = -2; // Auto-size columns based on content
            }

            lvFizickaLica.Refresh();

            foreach (ColumnHeader column in lvPravnaLica.Columns)
            {
                column.Width = -2; // Auto-size columns based on content
            }

            lvPravnaLica.Refresh();

        }

        private void lvFizickaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvFizickaLica.SelectedIndices.Count > 0 ? lvFizickaLica.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            _selectedOcena = _ocene[selectedIndex];

            lblKupacJe.Text = _selectedOcena.TipKupca;
            lbl1Kupac.Text = "Ime:";
            lblImeKupca.Text = _selectedOcena.ImeKupca;
            lbl2Kupac.Text = "Prezime:";
            lblPrezimeKupca.Text = _selectedOcena.PrezimeKupca;
            lbl3Kupac.Text = "Email:";
            lblEmailKupca.Text = _selectedOcena.EmailKupca;
            lbl4Kupac.Text = "Telefon:";
            lblTelefonKupca.Text = _selectedOcena.TelefonKupca;

            // Prodavac
            lblImeProdavca.Text = _selectedOcena.ImeProdavca;
            lblPrezimeProdavca.Text = _selectedOcena.PrezimeProdavca;
            lblPozicijaProdavca.Text = _selectedOcena.PozicijaProdavca;
            lblTelefonProdavca.Text = _selectedOcena.TelefonProdavca;

            lblOcena.Text = $"Ocena: {_selectedOcena.Ocena.ToString()}";
        }

        private void lvPravnaLica_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvFizickaLica.SelectedIndices.Count > 0 ? lvFizickaLica.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            _selectedOcena = _ocene[selectedIndex];

            // Pravno lice
            lblKupacJe.Text = _selectedOcena.TipKupca;
            lbl1Kupac.Text = "PIB:";
            lblImeKupca.Text = _selectedOcena.PIBKupca;
            lbl2Kupac.Text = "Naziv:";
            lblPrezimeKupca.Text = _selectedOcena.NazivFirmeKupca;
            lbl3Kupac.Text = "Sedište:";
            lblEmailKupca.Text = _selectedOcena.SedisteFirmeKupca;
            lbl4Kupac.Text = "Kontakt osoba:";
            lblTelefonKupca.Text = _selectedOcena.KontaktOsobaFirme;

            // Prodavac
            lblImeProdavca.Text = _selectedOcena.ImeProdavca;
            lblPrezimeProdavca.Text = _selectedOcena.PrezimeProdavca;
            lblPozicijaProdavca.Text = _selectedOcena.PozicijaProdavca;
            lblTelefonProdavca.Text = _selectedOcena.TelefonProdavca;

            lblOcena.Text = $"Ocena: {_selectedOcena.Ocena.ToString()}";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedOcena == null)
            {
                MessageBox.Show("Molimo izaberite ocenu koju želite da obrišete.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _jeOcenioService.Delete(_selectedOcena.ID);

            if (result.IsSuccess)
            {
                LoadOcene();
                MessageBox.Show("Ocena je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
