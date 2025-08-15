using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.Entities;
using auto_salon.Presentation.FOcene;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IZaposleniService _zaposleniService;
        private IList<ZaposleniDTO> _zaposleni = [];

        public ZaposleniUC(IServiceProvider serviceProvider, IZaposleniService zaposleniService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
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
                lvZaposleni.Items.Clear();

                foreach (var zaposleni in _zaposleni)
                {
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

            int selectedRowIndex = lvZaposleni.SelectedItems[0].Index;

            var form = ActivatorUtilities.CreateInstance<EditZaposleni>(_serviceProvider, _zaposleni[selectedRowIndex]);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void lvZaposleni_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvZaposleni.SelectedIndices.Count > 0 ? lvZaposleni.SelectedIndices[0] : -1;
            if (selectedIndex == -1)
                return;

            SalonDTO salonUKomeJeZaposlen = _zaposleni[selectedIndex].Salon!;

            lblID.Text = salonUKomeJeZaposlen.ID.ToString();
            lblNaziv.Text = salonUKomeJeZaposlen.Naziv;
            lblDrzava.Text = salonUKomeJeZaposlen.Drzava;
            lblGrad.Text = salonUKomeJeZaposlen.Grad;
            lblRadnoVreme.Text = salonUKomeJeZaposlen.RadnoVreme;
            lblKontaktTelefon.Text = salonUKomeJeZaposlen.KontaktTelefon;
            lblBrZaposlenih.Text = salonUKomeJeZaposlen.BrojZaposlenih.ToString();
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

            int selectedRowIndex = lvZaposleni.SelectedItems[0].Index;
            ZaposleniDTO zaposleni = _zaposleni[selectedRowIndex];

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
    }
}
