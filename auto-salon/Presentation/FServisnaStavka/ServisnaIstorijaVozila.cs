using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
namespace auto_salon.Presentation.FServisnaStavka
{
    public partial class ServisnaIstorijaVozila : Form
    {
        private readonly IServisnaStavkaService _servisnaStavkaService;
        private readonly VoziloTableDTO _vozilo;

        public ServisnaIstorijaVozila(VoziloTableDTO vozilo, IServisnaStavkaService servisnaStavkaService)
        {
            InitializeComponent();
            _vozilo = vozilo;
            _servisnaStavkaService = servisnaStavkaService;

            this.Text = $"Servisna Istorija Vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model}";

            LoadData();
        }

        private void LoadData()
        {
            // TODO: Implementirati učitavanje podataka o servisnim stavkama za vozilo
        }
    }
}
