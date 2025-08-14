using Antlr.Runtime.Tree;
using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FSalon;
using Microsoft.Extensions.DependencyInjection;

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

            // Define columns for ListView lvPromotivnePonude
            lvPromotivnePonude.Columns.Add("ID");
            lvPromotivnePonude.Columns.Add("Naziv");
            lvPromotivnePonude.Columns.Add("Popust [%]");
            lvPromotivnePonude.Columns.Add("Datum od");
            lvPromotivnePonude.Columns.Add("Datum do");
            lvPromotivnePonude.Columns.Add("Uslovi");

            // Define columns for ListView lvVozila
            lvVozila.Columns.Add("Status");
            lvVozila.Columns.Add("Stanje");
            lvVozila.Columns.Add("Broj šasije");
            lvVozila.Columns.Add("Cena");
            lvVozila.Columns.Add("Proizvođač");
            lvVozila.Columns.Add("Model");
            lvVozila.Columns.Add("Boja");
            lvVozila.Columns.Add("Broj vrata");
            lvVozila.Columns.Add("Tip goriva");
            lvVozila.Columns.Add("Snaga motora");
            lvVozila.Columns.Add("Kilometraža");
            lvVozila.Columns.Add("Godina proizvodnje");

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

        private void lvPromotivnePonude_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lvPromotivnePonude.SelectedItems.Count > 0 ? lvPromotivnePonude.SelectedItems[0].Index : -1;
            if (selectedIndex == -1)
                return;

            int promotivnaPonudaId = _promotivnePonude[selectedIndex].ID;

            var result = _promotivnaPonudaService.GetVozilaPromotivnePonude(promotivnaPonudaId);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Popuni lvVozila
            lvVozila.Items.Clear();
            foreach (var vozilo in result.Data!)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    vozilo.JeProdato ? "Prodato" : "Dostupno",
                    vozilo.Stanje,
                    vozilo.BrojSasije,
                    vozilo.Cena.ToString("C2"),
                    vozilo.NazivProizvodjaca ?? "N/A",
                    vozilo.Model,
                    vozilo.Boja,
                    vozilo.BrojVrata.ToString(),
                    vozilo.TipGoriva.ToString(),
                    vozilo.SnagaMotora.ToString(),
                    vozilo.Kilometraza.ToString(),
                    vozilo.GodinaProizvodnje.ToString()
                });

                lvVozila.Items.Add(item);

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvVozila.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvVozila.Refresh();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lvPromotivnePonude.SelectedItems.Count > 0 ? lvPromotivnePonude.SelectedItems[0].Index : -1;
            if (selectedIndex == -1)
            {
                MessageBox.Show("Molimo izaberite promotivnu ponudu koju želite da obrišete.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int promotivnaPonudaId = _promotivnePonude[selectedIndex].ID;

            var result = _promotivnaPonudaService.Delete(promotivnaPonudaId);

            if (result.IsSuccess)
            {
                lvVozila.Items.Clear();
                LoadData();
                MessageBox.Show("Promotivna ponuda je uspešno obrisana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = _serviceProvider.GetRequiredService<AddPromotivnaPonuda>();
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
