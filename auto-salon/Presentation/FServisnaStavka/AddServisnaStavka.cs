using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FServisnaStavka
{
    public partial class AddServisnaStavka : Form
    {
        private readonly IServisnaStavkaService _servisnaStavkaService;
        private VoziloTableDTO _vozilo;

        public AddServisnaStavka(VoziloTableDTO vozilo, IServisnaStavkaService servisnaStavkaService)
        {
            InitializeComponent();
            _servisnaStavkaService = servisnaStavkaService;
            _vozilo = vozilo;
        }

        private void cbxUserCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUserCurrentDate.Checked == true)
                dtpDatum.Enabled = false;
            else
                dtpDatum.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxOpis.Text))
            {
                MessageBox.Show("Molimo unesite opis servisne stavke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxOpis.Focus();
                return;
            }

            if (!cbxUserCurrentDate.Checked && dtpDatum.Value > DateTime.Now)
            {
                MessageBox.Show("Datum servisne stavke ne može biti u budućnosti.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatum.Focus();
                return;
            }

            if (!cbxUserCurrentDate.Checked && dtpDatum.Value.Year < _vozilo.GodinaProizvodnje)
            {
                MessageBox.Show("Datum servisne stavke ne može biti pre godine proizvodnje vozila.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDatum.Focus();
                return;
            }

            ServisnaStavkaDTO servisnaStavka = new ServisnaStavkaDTO
            {
                Datum = cbxUserCurrentDate.Checked ? DateTime.Now : dtpDatum.Value,
                Opis = tbxOpis.Text.Trim()
            };
            
            var result = _servisnaStavkaService.AddServisnaStavkaToVozilo(servisnaStavka, _vozilo.BrojSasije);

            if (result.IsSuccess)
            {
                MessageBox.Show("Servisna stavka uspešno dodata.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
