using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Presentation.FSalon;
using Microsoft.Extensions.DependencyInjection;

namespace auto_salon.Presentation.FServisnaStavka
{
    public partial class ServisnaIstorijaVozila : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IServisnaStavkaService _servisnaStavkaService;
        private readonly VoziloTableDTO _vozilo;
        private IList<ServisnaStavkaDTO> _servisneStavke = [];

        public ServisnaIstorijaVozila(VoziloTableDTO vozilo, IServiceProvider serviceProvider, IServisnaStavkaService servisnaStavkaService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _vozilo = vozilo;
            _servisnaStavkaService = servisnaStavkaService;

            this.Text = $"Servisna Istorija Vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model} | {_vozilo.BrojSasije}";

            DefineColumnNames();
            LoadData();
        }

        private void LoadData()
        {
            var result = _servisnaStavkaService.GetAllByBrojSasije(_vozilo.BrojSasije);

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _servisneStavke = result.Data!;

            lvServisneStavke.Items.Clear();

            foreach (var stavka in result.Data!)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    stavka.ID.ToString(),
                    stavka.Datum.ToString("dd.MM.yyyy"),
                    stavka.Opis
                });

                lvServisneStavke.Items.Add(item);
            }

            // Automatically resize columns based on content
            foreach (ColumnHeader column in lvServisneStavke.Columns)
            {
                column.Width = -2; // -2 means auto-size to content
            }

            lvServisneStavke.Refresh();
        }

        private void DefineColumnNames()
        {
            lvServisneStavke.Columns.Add("ID");
            lvServisneStavke.Columns.Add("Datum");
            lvServisneStavke.Columns.Add("Opis");
        }

        #region Event Handlers

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = ActivatorUtilities.CreateInstance<AddServisnaStavka>(_serviceProvider, _vozilo);
            DialogResult dialogResult = form.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                LoadData();
            }
        }

        #endregion
    }
}
