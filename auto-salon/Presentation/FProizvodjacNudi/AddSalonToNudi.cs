using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FProizvodjacNudi
{
    public partial class AddSalonToNudi : Form
    {
        private readonly ISalonService _salonService;
        private ProizvodjacDTO _proizvodjacDto;
        private IList<SalonDTO> _saloni = [];

        public AddSalonToNudi(ISalonService salonService, ProizvodjacDTO proizvodjacDto)
        {
            InitializeComponent();
            _salonService = salonService;
            _proizvodjacDto = proizvodjacDto;

            // Define columns for ListView lvSaloni
            lvSaloni.Columns.Add("ID");
            lvSaloni.Columns.Add("Naziv");
            lvSaloni.Columns.Add("Adresa");
            lvSaloni.Columns.Add("Grad");
            lvSaloni.Columns.Add("Država");
            lvSaloni.Columns.Add("Kontakt Telefon");
            lvSaloni.Columns.Add("Radno Vreme");
        }

        private void AddSalonToNudi_Load(object sender, EventArgs e)
        {
            var result = _salonService.GetSaloniInNudi(_proizvodjacDto.ID);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            _saloni = result.Data!;

            if (_saloni.Count == 0)
            {
                MessageBox.Show("Nema salona koji se mogu dodati u ponudu.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            lvSaloni.Items.Clear();
            foreach (var salon in _saloni)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    salon.ID.ToString(),
                    salon.Naziv,
                    salon.Adresa,
                    salon.Grad,
                    salon.Drzava,
                    salon.KontaktTelefon,
                    salon.RadnoVreme
                });
                lvSaloni.Items.Add(item);
            }

            foreach (ColumnHeader column in lvSaloni.Columns)
                column.Width = -2; // Auto size to fit content

            lvSaloni.Refresh();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            var selectedItems = lvSaloni.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => int.Parse(item.SubItems[0].Text)) // ID je u prvoj koloni
                .ToList();

            if (selectedItems.Count == 0)
            { 
                MessageBox.Show("Molimo izaberite barem jedan salon.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = _salonService.AddSaloniToNudi(_proizvodjacDto.ID, selectedItems);

            if (result.IsSuccess)
            {
                MessageBox.Show("Saloni su uspešno dodati u ponudu.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
