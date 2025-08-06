using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FUgovori
{
    public partial class UgovoriUC : UserControl
    {
        private readonly IUgovoriService _ugovoriService;
        private IList<UgovorTableDTO> _ugovori = [];

        public UgovoriUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _ugovoriService = new UgovoriService();

            // Define columns for ListView
            lvUgovori.Columns.Add("ID");
            lvUgovori.Columns.Add("Broj Sasije Vozila");
            lvUgovori.Columns.Add("JMBG Prodavca");
            lvUgovori.Columns.Add("ID Kupca");
            lvUgovori.Columns.Add("Nacin Placanja");
            lvUgovori.Columns.Add("Dodatna Oprema");
            lvUgovori.Columns.Add("Konacna Ocena");
            lvUgovori.Columns.Add("Ocena Prodavca");

            LoadData();
        }

        private void LoadData()
        {
            var result = _ugovoriService.GetAll();

            if (result.IsSuccess)
            {
                _ugovori = result.Data!;

                lvUgovori.Items.Clear();
                foreach (var ugovor in _ugovori)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        ugovor.ID.ToString(),
                        ugovor.BrojSasije,
                        ugovor.JmbgProdavca,
                        ugovor.KupacId.ToString(),
                        ugovor.NacinPlacanja.ToString(),
                        ugovor.DodatnaOprema,
                        ugovor.KonacnaOcena.ToString(),
                        ugovor.OcenaProdavca.ToString()
                    });

                    lvUgovori.Items.Add(item);
                }

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvUgovori.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvUgovori.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvUgovori.SelectedItems.Count == 0)
            {
                MessageBox.Show(
                    "Molimo izaberite ugovor koji želite da obrišete.",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int selectedRowIndex = lvUgovori.SelectedItems[0].Index;
            int ugovorId = _ugovori[selectedRowIndex].ID;
            var result = _ugovoriService.Delete(ugovorId);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show(
                    "Ugovor je uspešno obrisan.",
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
