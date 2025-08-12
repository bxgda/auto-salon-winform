using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FServisnaStavka
{
    public partial class EditServisnaStavka : Form
    {
        private readonly IServisnaStavkaService _servisnaStavkaService;
        private ServisnaStavkaDTO _servisnaStavkaDTO;
        private VoziloTableDTO _vozilo;

        public EditServisnaStavka(IServisnaStavkaService servisnaStavkaService, ServisnaStavkaDTO servisnaStavkaDTO, VoziloTableDTO voziloTableDTO)
        {
            InitializeComponent();
            _servisnaStavkaService = servisnaStavkaService;
            _servisnaStavkaDTO = servisnaStavkaDTO;
            _vozilo = voziloTableDTO;

            LoadUIWithData();
        }
        private void LoadUIWithData()
        {
            tbxOpis.Text = _servisnaStavkaDTO.Opis;
            dtpDatum.Value = _servisnaStavkaDTO.Datum;
            cbxUserCurrentDate.Checked = false;
        }

        private void cbxUserCurrentDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxUserCurrentDate.Checked == true)
            {
                dtpDatum.Enabled = false;
                dtpDatum.Value = DateTime.Now;
            }
            else
                dtpDatum.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
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

                _servisnaStavkaDTO.Opis = tbxOpis.Text.Trim();
                _servisnaStavkaDTO.Datum = cbxUserCurrentDate.Checked ? DateTime.Now : dtpDatum.Value;

                var result = _servisnaStavkaService.Update(_servisnaStavkaDTO);

                if (result.IsSuccess)
                {
                    MessageBox.Show("Servisna stavka uspešno ažurirana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška pri ažuriranju servisne stavke: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

}
