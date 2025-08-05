using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniSalona : Form
    {
        private readonly IZaposleniService _zaposleniService;
        private readonly SalonDTO _salon;
        private IList<ZaposleniDTO> _zapos = [];

        public ZaposleniSalona(SalonDTO salon)
        {
            InitializeComponent();
            _zaposleniService = new ZaposleniService();
            _salon = salon;

            // Define columns for ListView
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

            this.Text = $"Zaposleni salona: {_salon.Naziv}";

            LoadData();
        }

        private void LoadData()
        {
            var result = _zaposleniService.GetBySalonId(_salon.ID);
            if (result.IsSuccess)
            {
                _zapos = result.Data!;
                lvZaposleni.Items.Clear();

                foreach (var zaposleni in _zapos)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        zaposleni.JMBG,
                        zaposleni.Ime,
                        zaposleni.Prezime,
                        zaposleni.Uloga.ToString(),
                        zaposleni.Pozicija,
                        zaposleni.DatumZaposlenja.ToShortDateString(),
                        zaposleni.KontaktTelefon,
                        zaposleni.Email ?? "N/A",
                        zaposleni.Adresa ?? "N/A",
                        zaposleni.DatumPostavljenja.ToShortDateString()
                    });
                    lvZaposleni.Items.Add(item);
                }

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvZaposleni.Columns)
                {
                    column.Width = -2; // Auto-size to fit content
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
                    "Molimo izaberite zaposlenog kojeg želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = lvZaposleni.SelectedItems[0].Index;
            string jmbg = _zapos[selectedRowIndex].JMBG;

            var result = _zaposleniService.Delete(jmbg);

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
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new AddZaposleni(_zaposleniService, _salon).ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
