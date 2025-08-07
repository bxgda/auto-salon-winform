using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class ZaposleniSalona : Form
    {
        private readonly IZaposleniService _zaposleniService;
        private readonly IServiceProvider _serviceProvider;
        private readonly SalonDTO _salon;
        private IList<ZaposleniDTO> _zaposleni = [];

        // Konstruktor za DI
        public ZaposleniSalona(SalonDTO salon, IZaposleniService zaposleniService, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _salon = salon;
            _zaposleniService = zaposleniService;
            _serviceProvider = serviceProvider;

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
                        zaposleni.Email ?? "",
                        zaposleni.Adresa ?? "",
                        zaposleni.DatumPostavljenja == default
                            ? ""
                            : zaposleni.DatumPostavljenja.ToShortDateString()
                    });
                    lvZaposleni.Items.Add(item);
                }

                // Auto resize
                foreach (ColumnHeader column in lvZaposleni.Columns)
                {
                    column.Width = -2;
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
            string jmbg = _zaposleni[selectedRowIndex].JMBG;

            var result = _zaposleniService.Delete(jmbg);

            if (result.IsSuccess)
            {
                LoadData();
                MessageBox.Show("Zaposleni je uspešno obrisan.",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = ActivatorUtilities.CreateInstance<AddZaposleni>(_serviceProvider, _salon);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
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
    }
}
