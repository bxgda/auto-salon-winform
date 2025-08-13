using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FVozilo
{
    public partial class EditVozilo : Form
    {
        private readonly IVoziloService _voziloService;
        private readonly ISalonService _salonService;
        private IList<SalonComboboxDTO> _saloni = [];
        private VoziloTableDTO _vozilo;

        public EditVozilo(IVoziloService voziloService, ISalonService salonService, VoziloTableDTO vozilo)
        {
            InitializeComponent();
            _voziloService = voziloService;
            _salonService = salonService;
            _vozilo = vozilo;

            if (_vozilo.Stanje == "Novo")
            {
                dtpDatumRegistracije.Enabled = false;
                lblDatumRegistracije.Enabled = false;
            }

            this.Text = $"Uređivanje vozila: {_vozilo.NazivProizvodjaca} {_vozilo.Model} | {_vozilo.BrojSasije}";

            LoadSaloni();
            LoadVoziloData();
        }

        #region Load Data

        private void LoadSaloni()
        {
            var result = _salonService.GetAllByStanjeVozila(_vozilo.Stanje);
            if (result.IsSuccess)
            {
                _saloni = result.Data!;

                cbSaloni.Items.Clear();

                List<SalonComboboxItem> salonItems = _saloni.Select(s => new SalonComboboxItem(s.ID, s.Naziv)).ToList();
                
                cbSaloni.DataSource = salonItems;
                cbSaloni.DisplayMember = "Naziv";
                cbSaloni.ValueMember = "ID";

                cbSaloni.SelectedItem = salonItems.FirstOrDefault(s => s.Naziv == _vozilo.NazivSalona);
            }
            else
            {
                MessageBox.Show("Greška prilikom učitavanja salona: " + result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVoziloData()
        {
            tbxBrSasije.Text = _vozilo.BrojSasije;
            tbxMarka.Text = _vozilo.NazivProizvodjaca;
            tbxModel.Text = _vozilo.Model;
            numKilometraza.Value = _vozilo.Kilometraza;
            numSnagaMotora.Value = _vozilo.SnagaMotora;
            numGodinaProizvodnje.Value = _vozilo.GodinaProizvodnje;
            cbTipGoriva.SelectedItem = cbxEnumToItem(_vozilo.TipGoriva);
            tbxBoja.Text = _vozilo.Boja;
            cbBrojVrata.SelectedItem = _vozilo.BrojVrata.ToString();
            dtpDatumRegistracije.Value = _vozilo.DatumRegistracije ?? DateTime.Now;
            numBrojVlasnika.Value = _vozilo.BrojVlasnika;
        }

        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string model = tbxModel.Text.Trim();
            int kilometraza = (int)numKilometraza.Value;
            int snagaMotora = (int)numSnagaMotora.Value;
            int godinaProizvodnje = (int)numGodinaProizvodnje.Value;
            TipGoriva tipGoriva = cbxItemToEnum(cbTipGoriva.SelectedItem?.ToString() ?? string.Empty);
            string boja = tbxBoja.Text.Trim();
            int brojVrata = int.TryParse(cbBrojVrata.SelectedItem?.ToString(), out int brVrata) ? brVrata : 0;
            DateTime datumRegistracije = dtpDatumRegistracije.Value;

            if (string.IsNullOrWhiteSpace(model) ||
                kilometraza < 0 ||
                snagaMotora <= 0 ||
                godinaProizvodnje <= 0 ||
                string.IsNullOrWhiteSpace(boja) ||
                brojVrata <= 0 ||
                string.IsNullOrWhiteSpace(cbTipGoriva.SelectedItem?.ToString()))
            {
                MessageBox.Show("Molimo popunite sva obavezna polja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (godinaProizvodnje > datumRegistracije.Year)
            {
                MessageBox.Show("Godina proizvodnje ne može biti veća od godine registracije.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VoziloTableDTO updatedVozilo = new VoziloTableDTO
            {
                BrojSasije = _vozilo.BrojSasije, // Broj sasije se ne menja
                Model = _vozilo.Model, // Naziv modela ostaje isti
                Stanje = _vozilo.Stanje, // Stanje vozila ostaje isto
                Kilometraza = kilometraza,
                SnagaMotora = snagaMotora,
                GodinaProizvodnje = godinaProizvodnje,
                TipGoriva = tipGoriva,
                Boja = boja,
                BrojVrata = brojVrata,
                DatumRegistracije = _vozilo.Stanje == "Novo" ? _vozilo.DatumRegistracije : datumRegistracije,
                BrojVlasnika = (int)numBrojVlasnika.Value,
                JeProdato = _vozilo.JeProdato, // Prodato stanje ostaje isto
                NazivProizvodjaca = _vozilo.NazivProizvodjaca // Proizvođač ostaje isti
            };

            int selectedSalonId = (cbSaloni.SelectedItem as SalonComboboxItem)!.ID;

            var result = _voziloService.Update(updatedVozilo, selectedSalonId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Vozilo uspešno ažurirano.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Greška prilikom ažuriranja vozila: " + result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Helpers
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

        private string cbxEnumToItem(TipGoriva tipGoriva)
        {
            return tipGoriva switch
            {
                TipGoriva.DIZEL => "Dizel",
                TipGoriva.BENZIN => "Benzin",
                TipGoriva.ELEKTRICNI => "Struja",
                TipGoriva.HIDROGEN => "Hidrogen",
                TipGoriva.PLIN => "Plin",
                TipGoriva.METAN => "Metan",
                TipGoriva.HIBRID => "Hibrid",
                _ => throw new NotImplementedException(),
            };
        }

        #endregion
    }

    class SalonComboboxItem
    {
        public int ID { get; set; }
        public string Naziv { get; set; }

        public SalonComboboxItem(int id, string naziv)
        {
            ID = id;
            Naziv = naziv;
        }
    }
}
