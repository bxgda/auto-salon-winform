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
            PopuniProizvodjace();

            cbMarka.SelectedIndex = -1;
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

        private class MarkaItem
        {
            public string Naziv { get; set; }
            public int ID { get; set; }
            public MarkaItem(string naziv, int id)
            {
                Naziv = naziv;
                ID = id;
            }
            public override string ToString()
            {
                return Naziv;
            }
        }

        private void PopuniProizvodjace()
        {
            IList<Proizvodjac> proizvodjaci;
            if (_salon.Tip == "Nova")
            {
                var result = _proizvodjacService.GetProizvodjaciZaSalonNova(_salon.ID);
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proizvodjaci = result.Data!;
            }
            else
            {
                var result = _proizvodjacService.GetSviProizvodjaci();
                if (!result.IsSuccess)
                {
                    MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                proizvodjaci = result.Data!;
            }

            cbMarka.Items.Clear();

            List<MarkaItem> markaItems = new List<MarkaItem>();

            foreach (var p in proizvodjaci)
            {
                markaItems.Add(new MarkaItem(p.Naziv, p.ID));
            }
            cbMarka.DataSource = markaItems;
            cbMarka.DisplayMember = "Naziv";
            cbMarka.ValueMember = "ID";
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
            int proizvodjacId;
            string model = tbxModel.Text.Trim();
            int kilometraza = (int)numKilometraza.Value;
            int snagaMotora = (int)numSnagaMotora.Value;
            int godinaProizvodnje = (int)numGodinaProizvodnje.Value;
            string boja = tbxBoja.Text.Trim();
            int brojVrata = int.TryParse(cbBrojVrata.SelectedItem?.ToString(), out int brVrata) ? brVrata : 0;
            TipGoriva tipGoriva;

            if (string.IsNullOrWhiteSpace(brojSasije) ||
                cbMarka.SelectedItem == null ||
                string.IsNullOrWhiteSpace(model) ||
                kilometraza < 0 ||
                snagaMotora <= 0 ||
                string.IsNullOrWhiteSpace(boja) ||
                brojVrata <= 0 ||
                string.IsNullOrWhiteSpace(cbTipGoriva.SelectedItem?.ToString()) ||
                rbNovo.Checked == false && rbPolovno.Checked == false)
            {
                MessageBox.Show("Molimo popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                proizvodjacId = (cbMarka.SelectedItem as MarkaItem)!.ID;
                tipGoriva = cbxItemToEnum(cbTipGoriva.SelectedItem?.ToString() ?? string.Empty);
            }

            DateTime datumRegistracije;
            int brojVlasnika;
            if (rbPolovno.Checked)
            {
                datumRegistracije = dtpDatumRegistracije.Value;
                brojVlasnika = (int)numBrojVlasnika.Value;
            }

            VoziloTableDTO newVozilo = new VoziloTableDTO
            {
                Stanje = rbNovo.Checked ? "Novo" : "Polovno",
                BrojSasije = brojSasije,
                Model = model,
                Kilometraza = kilometraza,
                SnagaMotora = snagaMotora,
                GodinaProizvodnje = godinaProizvodnje,
                Boja = boja,
                BrojVrata = brojVrata,
                TipGoriva = tipGoriva
            };

            var result = _voziloService.Add(newVozilo, _salon.ID, proizvodjacId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Vozilo uspešno dodato.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
