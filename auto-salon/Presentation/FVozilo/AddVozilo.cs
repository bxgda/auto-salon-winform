using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FVozilo
{

    public partial class AddVozilo : Form
    {
        private readonly ISalonService _salonService;
        private readonly IVoziloService _voziloService;
        private readonly IProizvodjacService _proizvodjacService;
        private readonly SalonDTO _salon;

        public AddVozilo(SalonDTO salon, IVoziloService voziloService, ISalonService salonService, IProizvodjacService proizvodjacService)
        {
            InitializeComponent();
            _salon = salon;
            _voziloService = voziloService;
            _salonService = salonService;
            _proizvodjacService = proizvodjacService;

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

        private void rbNovo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumRegistracije.Enabled = false;
            numBrojVlasnika.Enabled = false;
        }

        private void rbPolovno_CheckedChanged(object sender, EventArgs e)
        {
            dtpDatumRegistracije.Enabled = true;
            numBrojVlasnika.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string brojSasije = tbxBrSasije.Text.Trim();
            string marka = cbMarka.Text.Trim();
            string model = tbxModel.Text.Trim();
            int kilometraza = (int)numKilometraza.Value;
            int snagaMotora = (int)numSnagaMotora.Value;
            int godinaProizvodnje = (int)numGodinaProizvodnje.Value;
            TipGoriva tipGoriva1 = cbxItemToEnum(cbTipGoriva.SelectedItem?.ToString() ?? string.Empty);
            string boja = tbxBoja.Text.Trim();
            int brojVrata = (int)numBrVrata.Value;
            DateTime datumRegistracije;
            if (rbPolovno.Checked) datumRegistracije = dtpDatumRegistracije.Value;
            int brojVlasnika;
            if (rbPolovno.Checked) brojVlasnika = (int)numBrojVlasnika.Value;
        }
    }
}
