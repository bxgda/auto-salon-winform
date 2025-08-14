using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FPromotivnePonude
{
    public partial class AddVoziloToPromotivnaPonuda : Form
    {
        private PromotivnaPonudaDTO _promotivnaPonuda;
        private readonly IVoziloService _voziloService;
        private IList<VoziloTableDTO> _vozila = [];

        public AddVoziloToPromotivnaPonuda(PromotivnaPonudaDTO promotivnaPonuda, IVoziloService voziloService)
        {
            InitializeComponent();
            _promotivnaPonuda = promotivnaPonuda;
            _voziloService = voziloService;

            this.Text = $"Dodavanje vozila za ponudu: {_promotivnaPonuda.NazivPromocije}";

            // Define columns for ListView
            lvVozila.Columns.Add("Status");
            lvVozila.Columns.Add("Stanje");
            lvVozila.Columns.Add("Broj šasije");
            lvVozila.Columns.Add("Cena ($)");
            lvVozila.Columns.Add("Proizvođač");
            lvVozila.Columns.Add("Model");
            lvVozila.Columns.Add("Boja");
            lvVozila.Columns.Add("Broj vrata");
            lvVozila.Columns.Add("Tip goriva");
            lvVozila.Columns.Add("Snaga motora");
            lvVozila.Columns.Add("Kilometraža");
            lvVozila.Columns.Add("Godina proizvodnje");
        }

        private void AddVoziloToPromotivnaPonuda_Load(object sender, EventArgs e)
        {
            var result = _voziloService.GetVozilaNotInPonuda(_promotivnaPonuda.ID);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _vozila = result.Data!;

            if (_vozila.Count == 0)
            {
                MessageBox.Show("Nema vozila koja se mogu dodati u promotivnu ponudu.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            lvVozila.Items.Clear();
            foreach (var vozilo in _vozila)
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
            }

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvVozila.Columns)
                column.Width = -2; // Auto size to fit content

            lvVozila.Refresh();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            // Uzmi brojeve sasija svih selektovanih vozila
            var selectedSasije = lvVozila.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => item.SubItems[2].Text) // Broj sasije je u trecoj koloni
                .ToList();

            if (selectedSasije.Count == 0)
            {
                MessageBox.Show("Molimo izaberite vozila koja želite da dodate u promotivnu ponudu.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _voziloService.AddVozilaToPonuda(_promotivnaPonuda.ID, selectedSasije);

            if (result.IsSuccess)
            {
                MessageBox.Show("Vozila su uspešno dodata u promotivnu ponudu.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
