using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FTestVoznja
{
    public partial class TestVoznjaUC : UserControl
    {
        private readonly ITestVoznjaService _testVoznjaService;
        private IList<TestVoznjaTableDTO> _testVoznje = [];

        public TestVoznjaUC(ITestVoznjaService testVoznjaService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _testVoznjaService = testVoznjaService;

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
    }
}
