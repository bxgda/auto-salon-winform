using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FPromotivnePonude
{
    public partial class EditPromotivnaPonuda : Form
    {
        private readonly IPromotivnaPonudaService _promotivnaPonudaService;
        private PromotivnaPonudaDTO _ponudaDto;

        public EditPromotivnaPonuda(PromotivnaPonudaDTO ponudaDto, IPromotivnaPonudaService promovitnaPonudaService)
        {
            InitializeComponent();
            _ponudaDto = ponudaDto;
            _promotivnaPonudaService = promovitnaPonudaService;

            LoadUIWithData();
        }

        private void LoadUIWithData()
        {
            tbxNazivPromocije.Text = _ponudaDto.NazivPromocije;
            nudPopust.Value = _ponudaDto.PopustUProcentima;
            dtpOd.Value = _ponudaDto.DatumOd;
            dtpDo.Value = _ponudaDto.DatumDo;
            rtbUslovi.Text = _ponudaDto.Uslovi;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNazivPromocije.Text))
            {
                MessageBox.Show("Molimo unesite opis servisne stavke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNazivPromocije.Focus();
                return;
            }

            if (dtpOd.Value >= dtpDo.Value)
            {
                MessageBox.Show("Datum početka važenja mora biti pre datuma kraja važenja ponude.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpOd.Focus();
                return;
            }

            if (dtpDo.Value <= DateTime.Now)
            {
                MessageBox.Show("Datum kraja važenja ponude ne može biti u prošlosti ili današnji datum.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDo.Focus();
                return;
            }

            _ponudaDto.NazivPromocije = tbxNazivPromocije.Text.Trim();
            _ponudaDto.PopustUProcentima = nudPopust.Value;
            _ponudaDto.DatumOd = dtpOd.Value;
            _ponudaDto.DatumDo = dtpDo.Value;
            _ponudaDto.Uslovi = rtbUslovi.Text;

            var result = _promotivnaPonudaService.Update(_ponudaDto);

            if (result.IsSuccess)
            {
                MessageBox.Show("Promotivna ponuda uspešno ažurirana.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
