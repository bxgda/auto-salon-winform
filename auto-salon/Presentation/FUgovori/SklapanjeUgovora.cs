using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FUgovori
{
    public partial class SklapanjeUgovora : Form
    {
        private readonly IUgovoriService _ugovoriService;
        private readonly IZaposleniService _zaposleniService;
        private readonly VoziloTableDTO _vozilo;

        public SklapanjeUgovora(VoziloTableDTO _vozilo, IUgovoriService ugovoriService, IZaposleniService zaposleniService)
        {
            InitializeComponent();
            this.Text = $"Prodaja vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model}";
            
            this._vozilo = _vozilo;
            _ugovoriService = ugovoriService;
            _zaposleniService = zaposleniService;

            // Define columns for ListView
            lvProdavci.Columns.Add("JMBG");
            lvProdavci.Columns.Add("Ime");
            lvProdavci.Columns.Add("Prezime");
            lvProdavci.Columns.Add("Uloga");
            lvProdavci.Columns.Add("Pozicija");
            lvProdavci.Columns.Add("Datum Zaposlenja");
            lvProdavci.Columns.Add("Kontakt Telefon");
            lvProdavci.Columns.Add("Email");
            lvProdavci.Columns.Add("Adresa");
            lvProdavci.Columns.Add("Datum Postavljenja");

            LoadProdavci();
        }

        private void LoadProdavci()
        {
            var result = _zaposleniService.GetAllProdavciKojiMoguDaProdajuVozilo(_vozilo.BrojSasije);

            if (result.IsSuccess)
            {
                lvProdavci.Items.Clear();
                foreach (var zaposleni in result.Data!)
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
                    lvProdavci.Items.Add(item);
                }

                // Automatically resize columns based on content
                foreach (ColumnHeader column in lvProdavci.Columns)
                {
                    column.Width = -2; // -2 means auto-size to content
                }

                lvProdavci.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
