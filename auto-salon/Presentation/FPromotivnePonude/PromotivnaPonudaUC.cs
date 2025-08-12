using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FPromotivnePonude
{
    public partial class PromotivnaPonudaUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IPromotivnaPonudaService _promotivnaPonudaService;
        private IList<PromotivnaPonudaDTO> _promotivnePonude = [];

        public PromotivnaPonudaUC(IServiceProvider serviceProvider, IPromotivnaPonudaService promotivnaPonudaService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _serviceProvider = serviceProvider;
            _promotivnaPonudaService = promotivnaPonudaService;

            // Define columns for ListView
            lvPromotivnePonude.Columns.Add("ID");
            lvPromotivnePonude.Columns.Add("Naziv");
            lvPromotivnePonude.Columns.Add("Popust [%]");
            lvPromotivnePonude.Columns.Add("Datum od");
            lvPromotivnePonude.Columns.Add("Datum do");
            lvPromotivnePonude.Columns.Add("Uslovi");

            LoadData();
        }

        private void LoadData()
        {
            var result = _promotivnaPonudaService.GetAll();

            if (result.IsSuccess)
            {
                _promotivnePonude = result.Data!;
                lvPromotivnePonude.Items.Clear();
                foreach (var ponuda in _promotivnePonude)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        ponuda.ID.ToString(),
                        ponuda.NazivPromocije,
                        ponuda.PopustUProcentima.ToString("F2"),
                        ponuda.DatumOd.ToShortDateString(),
                        ponuda.DatumDo.ToShortDateString(),
                        ponuda.Uslovi
                    });
                    lvPromotivnePonude.Items.Add(item);
                }

                foreach (ColumnHeader column in lvPromotivnePonude.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvPromotivnePonude.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
