using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;
using auto_salon.Entities;

namespace auto_salon.Presentation.FZaposleni
{
    public partial class EditZaposleni : Form
    {
        private readonly IZaposleniService _zaposleniService;
        private readonly ISalonService _salonService;
        private readonly ZaposleniDTO _zaposleni;
        private IList<SalonComboboxDTO> _saloni = [];

        public EditZaposleni(IZaposleniService zaposleniService, ZaposleniDTO zaposleni, ISalonService salonService)
        {
            InitializeComponent();
            _zaposleniService = zaposleniService;
            _salonService = salonService;
            _zaposleni = zaposleni;

            this.Text = $"Izmena zaposlenog: {zaposleni.Ime} {zaposleni.Prezime}";

            LoadUIWithData();
            LoadSaloniForCombobox();
        }

        private void LoadUIWithData()
        {
            tbxIme.Text = _zaposleni.Ime;
            tbxPrezime.Text = _zaposleni.Prezime;
            tbxJmbg.Text = _zaposleni.JMBG;
            tbxPozicija.Text = _zaposleni.Pozicija;
            dtpDatumZaposlenja.Value = _zaposleni.DatumZaposlenja;
            tbxKontaktTelefon.Text = _zaposleni.KontaktTelefon;
            tbxEmail.Text = _zaposleni.Email ?? string.Empty;
            tbxAdresa.Text = _zaposleni.Adresa ?? string.Empty;
            cbxStatus.SelectedItem = cbxStatusEnumToItem(_zaposleni.StatusZaposlenja);
            cbxUloga.SelectedItem = cbxEnumToItem(_zaposleni.Uloga);
        }

        private void LoadSaloniForCombobox()
        {
            var result = _salonService.GetAllForCombobox();

            if (result.IsSuccess)
            {
                _saloni = result.Data!;

                cbSaloni.Items.Clear();

                List<SalonComboboxItem> salonItems = _saloni.Select(s => new SalonComboboxItem(s.ID, s.Naziv)).ToList();
                
                cbSaloni.DataSource = salonItems;
                cbSaloni.DisplayMember = "Naziv";
                cbSaloni.ValueMember = "ID";

                cbSaloni.SelectedItem = salonItems.FirstOrDefault(s => s.Naziv == _zaposleni.Salon?.Naziv);
            }
            else
            {
                MessageBox.Show("Greška prilikom učitavanja salona: " + result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!TryGetZaposleniFromForm(out var zaposleniDto, out var errorMessage))
            {
                MessageBox.Show(errorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedSalonId = (cbSaloni.SelectedItem as SalonComboboxItem)!.ID;
            var result = _zaposleniService.Update(zaposleniDto, selectedSalonId);

            if (result.IsSuccess)
            {
                MessageBox.Show("Zaposleni uspešno izmenjen.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Helper Methods

        private bool TryGetZaposleniFromForm(out ZaposleniDTO zaposleni, out string errorMessage)
        {
            zaposleni = null!;
            errorMessage = string.Empty;

            // Required fields
            string ime = tbxIme.Text.Trim();
            string prezime = tbxPrezime.Text.Trim();
            string kontaktTelefon = tbxKontaktTelefon.Text.Trim();
            string pozicija = tbxPozicija.Text.Trim();
            string? uloga = cbxUloga.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(ime) ||
                string.IsNullOrWhiteSpace(prezime) ||
                string.IsNullOrWhiteSpace(kontaktTelefon) ||
                string.IsNullOrWhiteSpace(pozicija) ||
                string.IsNullOrWhiteSpace(uloga))
            {
                errorMessage = "Molimo popunite sva polja označena zvezdicom.";
                return false;
            }

            Uloga ulogaEnum = cbxItemToEnum(uloga);

            // Optional fields
            string email = tbxEmail.Text.Trim();
            string adresa = tbxAdresa.Text.Trim();

            zaposleni = new ZaposleniDTO
            {
                Ime = ime,
                Prezime = prezime,
                JMBG = _zaposleni.JMBG, // JMBG se ne menja
                Pozicija = pozicija,
                DatumZaposlenja = _zaposleni.DatumZaposlenja, // datum zaposlenja se ne menja
                Uloga = ulogaEnum,
                KontaktTelefon = kontaktTelefon,
                Email = email,
                Adresa = adresa,
                StatusZaposlenja = cbxItemToStatusEnum(cbxStatus.SelectedItem?.ToString() ?? "Aktivan"),
            };

            return true;
        }

        private string cbxStatusEnumToItem(StatusZaposlenja status)
        {
            return status switch
            {
                StatusZaposlenja.AKTIVAN => "Aktivan",
                StatusZaposlenja.NEAKTIVAN => "Neaktivan",
                StatusZaposlenja.NA_ODMORU => "Na odmoru",
                StatusZaposlenja.NA_BOLOVANJU => "Na bolovanju",
                _ => throw new NotImplementedException(),
            };
        }


        private StatusZaposlenja cbxItemToStatusEnum(string status)
        {
            return status switch
            {
                "Aktivan" => StatusZaposlenja.AKTIVAN,
                "Neaktivan" => StatusZaposlenja.NEAKTIVAN,
                "Na odmoru" => StatusZaposlenja.NA_ODMORU,
                "Na bolovanju" => StatusZaposlenja.NA_BOLOVANJU,
                _ => throw new NotImplementedException(),
            };
        }

        private Uloga cbxItemToEnum(string uloga)
        {
            return uloga switch
            {
                "Menadžer" => Uloga.MENADZER,
                "Prodavac" => Uloga.PRODAVAC,
                "Serviser" => Uloga.SERVISER,
                "Finansijski savetnik" => Uloga.FINANSIJSKI_SAVETNIK,
                _ => throw new NotImplementedException(),
            };
        }

        private string cbxEnumToItem(Uloga uloga)
        {
            return uloga switch
            {
                Uloga.MENADZER => "Menadžer",
                Uloga.PRODAVAC => "Prodavac",
                Uloga.SERVISER => "Serviser",
                Uloga.FINANSIJSKI_SAVETNIK => "Finansijski savetnik",
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
