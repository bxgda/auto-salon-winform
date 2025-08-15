using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.Entities;
using auto_salon.Presentation.FOcene;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Linq.Functions;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IZaposleniService _zaposleniService;
        private IList<ZaposleniDTO> _zaposleni = [];

        private string filter = "Sve"; // Default filter value

        public ZaposleniUC(IServiceProvider serviceProvider, IZaposleniService zaposleniService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            cbFilter.SelectedIndex = 0; // Set default filter to "Sve"

            _serviceProvider = serviceProvider;
            _zaposleniService = zaposleniService;

            // Define columns for ListView
            lvZaposleni.Columns.Add("JMBG");
            lvZaposleni.Columns.Add("Status");
            lvZaposleni.Columns.Add("Ime");
            lvZaposleni.Columns.Add("Prezime");
            lvZaposleni.Columns.Add("Uloga");
            lvZaposleni.Columns.Add("Pozicija");
            lvZaposleni.Columns.Add("Datum Zaposlenja");
            lvZaposleni.Columns.Add("Kontakt Telefon");
            lvZaposleni.Columns.Add("Email");
            lvZaposleni.Columns.Add("Adresa");
            lvZaposleni.Columns.Add("Datum Postavljenja");

            LoadData();
        }

        private void LoadData()
        {
            var result = _zaposleniService.GetAll();

            if (result.IsSuccess)
            {
                _zaposleni = result.Data!;
                InsertDataIntoListView();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite zaposlenog koji želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = lvZaposleni.SelectedItems[0].Index;
            string zaposleniId = _zaposleni[selectedRowIndex].JMBG;
            var result = _zaposleniService.Delete(zaposleniId);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show(
                    "Zaposleni je uspešno obrisan.",
                    "Uspeh",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    result.ErrorMessage,
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite zaposlenog čije podatke želite da izmenite.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Uzmi JMBG zaposlenog iz prve kolone (indeks 0)
            string selectedJmbg = lvZaposleni.SelectedItems[0].SubItems[0].Text;

            // Pronadji zaposlenog u _zaposleni po JMBG
            var zaposleni = _zaposleni.FirstOrDefault(z => z.JMBG == selectedJmbg);
            if (zaposleni == null)
            {
                MessageBox.Show(
                    "Došlo je do greške pri pronalaženju zaposlenog.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var form = ActivatorUtilities.CreateInstance<EditZaposleni>(_serviceProvider, zaposleni);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();

                // Selektuj opet izmenjenog zaposlenog (sa selectedJmbg prvom kolonom)
                foreach (ListViewItem item in lvZaposleni.Items)
                {
                    if (item.SubItems[0].Text == selectedJmbg)
                    {
                        item.Selected = true;
                        item.Focused = true;
                        item.EnsureVisible();
                        break;
                    }
                }
            }
        }

        private void lvZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count == 0)
                return;

            string selectedJmbg = lvZaposleni.SelectedItems[0].SubItems[0].Text;
            var zaposleni = _zaposleni.FirstOrDefault(z => z.JMBG == selectedJmbg);

            if (zaposleni == null || zaposleni.Salon == null)
            {
                lblID.Text = "";
                lblNaziv.Text = "";
                lblDrzava.Text = "";
                lblGrad.Text = "";
                lblRadnoVreme.Text = "";
                lblKontaktTelefon.Text = "";
                lblBrZaposlenih.Text = "";
                return;
            }

            var salon = zaposleni.Salon;
            lblID.Text = salon.ID.ToString();
            lblNaziv.Text = salon.Naziv;
            lblDrzava.Text = salon.Drzava;
            lblGrad.Text = salon.Grad;
            lblRadnoVreme.Text = salon.RadnoVreme;
            lblKontaktTelefon.Text = salon.KontaktTelefon;
            lblBrZaposlenih.Text = salon.BrojZaposlenih.ToString();
        }

        private void btnOceni_Click(object sender, EventArgs e)
        {
            if (lvZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite prodavca koga želite da izmenite.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Uzmi JMBG zaposlenog iz prve kolone (indeks 0)
            string selectedJmbg = lvZaposleni.SelectedItems[0].SubItems[0].Text;

            // Pronadji zaposlenog u _zaposleni po JMBG
            var zaposleni = _zaposleni.FirstOrDefault(z => z.JMBG == selectedJmbg);
            if (zaposleni == null)
            {
                MessageBox.Show(
                    "Došlo je do greške pri pronalaženju zaposlenog.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (zaposleni.Uloga != Uloga.PRODAVAC)
            {
                MessageBox.Show(
                    "Samo prodavci mogu biti ocenjeni.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var form = ActivatorUtilities.CreateInstance<OceniProdavca>(_serviceProvider, zaposleni);
            DialogResult dialogResult = form.ShowDialog();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedItem == null)
                return;

            filter = cbFilter.SelectedItem.ToString() ?? "Sve";

            InsertDataIntoListView();
        }

        private void InsertDataIntoListView()
        {
            lvZaposleni.Items.Clear();

            foreach (var zaposleni in _zaposleni)
            {
                if (filter == "Menadžer" && zaposleni.Uloga != Uloga.MENADZER)
                    continue;
                if (filter == "Serviser" && zaposleni.Uloga != Uloga.SERVISER)
                    continue;
                if (filter == "Prodavac" && zaposleni.Uloga != Uloga.PRODAVAC)
                    continue;
                if (filter == "Finansijski savetnik" && zaposleni.Uloga != Uloga.FINANSIJSKI_SAVETNIK)
                    continue;

                ListViewItem item = new ListViewItem(new string[]
                {
                        zaposleni.JMBG,
                        zaposleni.StatusZaposlenja.ToString(),
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

                lvZaposleni.Items.Add(item);
            }

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvZaposleni.Columns)
            {
                column.Width = -2; // -2 means auto-size to content
            }

            lvZaposleni.Refresh();
        }
    }
}
