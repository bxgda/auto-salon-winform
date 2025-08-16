using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FTestVoznja
{
    public partial class TestVoznjaUC : UserControl
    {
        private readonly ITestVoznjaService _testVoznjaService;
        private readonly IServiceProvider _serviceProvider;
        private IList<TestVoznjaTableDTO> _testVoznje = [];

        public TestVoznjaUC(ITestVoznjaService testVoznjaService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _testVoznjaService = testVoznjaService;
            _serviceProvider = serviceProvider;

            DefineColumnsForListView();
            LoadData();
        }

        private void DefineColumnsForListView()
        {
            lvTestVoznje.Columns.Add("ID");
            lvTestVoznje.Columns.Add("Datum");
            lvTestVoznje.Columns.Add("Vreme");
            lvTestVoznje.Columns.Add("Ocena");
            lvTestVoznje.Columns.Add("Zakljucak");
            lvTestVoznje.Columns.Add("Broj Sasije Vozila");
            lvTestVoznje.Columns.Add("JMBG Zaposlenog");
            lvTestVoznje.Columns.Add("ID Kupca");
        }

        private void LoadData()
        {
            var result = _testVoznjaService.GetAll();

            if (result.IsSuccess)
            {
                _testVoznje = result.Data!;

                lvTestVoznje.Items.Clear();
                foreach (var testVoznja in _testVoznje)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        testVoznja.ID.ToString(),
                        testVoznja.Datum.ToString("dd.MM.yyyy"),
                        testVoznja.Vreme,
                        testVoznja.Ocena.ToString(),
                        testVoznja.Zakljucak ?? "N/A",
                        testVoznja.BrojSasije,
                        testVoznja.JmbgZaposlenog,
                        testVoznja.KupacId.ToString()
                    });

                    lvTestVoznje.Items.Add(item);
                }

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvTestVoznje.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvTestVoznje.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetLabels()
        {
            lblKupacJe.Text = "/";
            lbl1Kupac.Text = "/";
            lblImeKupca.Text = "/";
            lbl2Kupac.Text = "/";
            lblPrezimeKupca.Text = "/";
            lbl3Kupac.Text = "/";
            lblEmailKupca.Text = "/";
            lbl4Kupac.Text = "/";
            lblTelefonKupca.Text = "/";
            lblBrojSasije.Text = "/";
            lblStanje.Text = "/";
            lblModel.Text = "/";
            lblGodinaProizvodnje.Text = "/";
            lblImeProdavca.Text = "/";
            lblPrezimeProdavca.Text = "/";
            lblPozicijaProdavca.Text = "/";
            lblTelefonProdavca.Text = "/";
        }

        private void lvTestVoznje_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvTestVoznje.SelectedIndices.Count > 0 ? lvTestVoznje.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            int testVoznjaId = _testVoznje[selectedIndex].ID;
            var result = _testVoznjaService.GetDetails(testVoznjaId);

            if (result.IsSuccess && result.Data != null)
            {
                TestVoznjaDetailsDTO selectedTestVoznja = result.Data!;

                lblKupacJe.Text = selectedTestVoznja.TipKupca;
                // Kupac
                if (selectedTestVoznja.TipKupca == "Fizicko lice")
                {
                    lbl1Kupac.Text = "Ime:";
                    lblImeKupca.Text = selectedTestVoznja.ImeKupca;
                    lbl2Kupac.Text = "Prezime:";
                    lblPrezimeKupca.Text = selectedTestVoznja.PrezimeKupca;
                    lbl3Kupac.Text = "Email:";
                    lblEmailKupca.Text = selectedTestVoznja.EmailKupca;
                    lbl4Kupac.Text = "Telefon:";
                    lblTelefonKupca.Text = selectedTestVoznja.TelefonKupca;
                }
                else if (selectedTestVoznja.TipKupca == "Pravno lice")
                {
                    lbl1Kupac.Text = "PIB:";
                    lblImeKupca.Text = selectedTestVoznja.PIBKupca;
                    lbl2Kupac.Text = "Naziv:";
                    lblPrezimeKupca.Text = selectedTestVoznja.NazivFirmeKupca;
                    lbl3Kupac.Text = "Sedište:";
                    lblEmailKupca.Text = selectedTestVoznja.SedisteFirmeKupca;
                    lbl4Kupac.Text = "Kontakt osoba:";
                    lblTelefonKupca.Text = selectedTestVoznja.KontaktOsobaFirme;
                }

                // Vozilo
                lblBrojSasije.Text = selectedTestVoznja.BrojSasije;
                lblStanje.Text = selectedTestVoznja.StanjeVozila;
                lblModel.Text = selectedTestVoznja.Model;
                lblGodinaProizvodnje.Text = selectedTestVoznja.GodinaProizvodnje.ToString();

                // Prodavac
                lblImeProdavca.Text = selectedTestVoznja.ImeZaposlenog;
                lblPrezimeProdavca.Text = selectedTestVoznja.PrezimeZaposlenog;
                lblPozicijaProdavca.Text = selectedTestVoznja.PozicijaZaposlenog;
                lblTelefonProdavca.Text = selectedTestVoznja.TelefonZaposlenog;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvTestVoznje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite test vožnju koju želite da obrišete.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvTestVoznje.SelectedItems[0].Index;
            int testVoznjaId = _testVoznje[selectedRowIndex].ID;
            var result = _testVoznjaService.Delete(testVoznjaId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Uspešno ste obrisali test vožnju.", "Obaveštenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetLabels();
                LoadData();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvTestVoznje.SelectedItems.Count == 0)
            {
                MessageBox.Show("Molimo izaberite test vožnju koju želite da izmenite.",
                    "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = lvTestVoznje.SelectedItems[0].Index;

            // Prosleđivanje DTO-a se i dalje može raditi ručno
            var form = ActivatorUtilities.CreateInstance<EditTestVoznja>(_serviceProvider, _testVoznje[selectedRowIndex]);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
                ResetLabels();
            }
        }
    }
}
