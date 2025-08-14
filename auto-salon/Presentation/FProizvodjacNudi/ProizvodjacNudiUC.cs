using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FProizvodjacNudi
{
    public partial class ProizvodjacNudiUC : UserControl
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IProizvodjacService _proizvodjacService;
        private IList<ProizvodjacDTO> _proizvodjaci = [];

        public ProizvodjacNudiUC(IServiceProvider serviceProvider, IProizvodjacService proizvodjacService)
        {
            InitializeComponent();

            _serviceProvider = serviceProvider;
            _proizvodjacService = proizvodjacService;

            this.Dock = DockStyle.Fill;

            // Define columns for ListView lvProizvodjaci
            lvProizvodjaci.Columns.Add("ID");
            lvProizvodjaci.Columns.Add("Naziv");

            // Define columns for ListView lvSaloni
            lvSaloni.Columns.Add("ID");
            lvSaloni.Columns.Add("Naziv");
            lvSaloni.Columns.Add("Adresa");
            lvSaloni.Columns.Add("Grad");
            lvSaloni.Columns.Add("Država");
            lvSaloni.Columns.Add("Kontakt Telefon");
            lvSaloni.Columns.Add("Radno Vreme");

            LoadData();
        }

        private void LoadData()
        {
            var result = _proizvodjacService.GetSviProizvodjaci();

            if (result.IsSuccess)
            {
                _proizvodjaci = result.Data!;
                lvProizvodjaci.Items.Clear();
                foreach (var proizvodjac in _proizvodjaci)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        proizvodjac.ID.ToString(),
                        proizvodjac.Naziv
                    });
                    lvProizvodjaci.Items.Add(item);
                }

                foreach (ColumnHeader column in lvProizvodjaci.Columns)
                {
                    column.Width = -2; // Auto size to fit content
                }

                lvProizvodjaci.Refresh();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lvProizvodjaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSaloni();
        }

        private void LoadSaloni()
        {
            int selectedIndex = lvProizvodjaci.SelectedItems.Count > 0 ? lvProizvodjaci.SelectedItems[0].Index : -1;
            if (selectedIndex == -1)
                return;

            int proizvodjacId = _proizvodjaci[selectedIndex].ID;

            var result = _proizvodjacService.GetSaloniZaProizvodjaca(proizvodjacId);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lvSaloni.Items.Clear();
            foreach (var salon in result.Data!)
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
            {
                column.Width = -2; // Auto size to fit content
            }

            lvSaloni.Refresh();
        }
    }
}
