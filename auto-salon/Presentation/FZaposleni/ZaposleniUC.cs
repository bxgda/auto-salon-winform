using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniUC : UserControl
    {
        private readonly IZaposleniService _zaposleniService;
        private IList<ZaposleniDTO> _zaposleni = [];

        public ZaposleniUC(IZaposleniService zaposleniService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _zaposleniService = zaposleniService;

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
    }
}
