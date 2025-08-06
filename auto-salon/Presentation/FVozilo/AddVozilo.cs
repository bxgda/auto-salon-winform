using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FVozilo
{

    public partial class AddVozilo : Form
    {
        private readonly ISalonService _salonService;
        private readonly IVoziloService _voziloService;
        private readonly SalonDTO _salon;

        public AddVozilo(IVoziloService voziloService, ISalonService salonService, SalonDTO salon)
        {
            InitializeComponent();
            _voziloService = voziloService;
            _salonService = salonService;
            _salon = salon;

            PostaviRadioButtonTip();
        }

        private void PostaviRadioButtonTip()
        {
            string tip = _salon.Tip;

            if (tip != "Kombinovan")
            {
                gbStanje.Enabled = false;
                if (tip == "Nova")
                    rbNovo.Checked = true;
                else
                    rbPolovno.Checked = true;
            }
        }

        private void AddVozilo_Load(object sender, EventArgs e)
        {

        }

        private TipGoriva cbxItemToEnum(string tipGoriva)
        {
            return tipGoriva switch
            {
                "Dizel" => TipGoriva.DIZEL,
                "Benzin" => TipGoriva.BENZIN,
                "Struja" => TipGoriva.ELEKTRICNI,
                "Hidrogen" => TipGoriva.HIDROGEN,
                "Plin" => TipGoriva.PLIN,
                "Metan" => TipGoriva.METAN,
                "Hibrid" => TipGoriva.HIBRID,
                _ => throw new NotImplementedException(),
            };
        }
    }
}
