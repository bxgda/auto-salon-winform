using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FPromotivnePonude
{
    public partial class AddPromotivnaPonuda : Form
    {
        private readonly IPromotivnaPonudaService _promotivnaPonudaService;

        public AddPromotivnaPonuda(IPromotivnaPonudaService promotivnaPonudaService)
        {
            InitializeComponent();
            _promotivnaPonudaService = promotivnaPonudaService;
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

            PromotivnaPonudaDTO promotivnaPonuda = new PromotivnaPonudaDTO
            {
                NazivPromocije = tbxNazivPromocije.Text.Trim(),
                PopustUProcentima = nudPopust.Value,
                DatumOd = dtpOd.Value,
                DatumDo = dtpDo.Value,
                Uslovi = rtbUslovi.Text.Trim()
            };

            var result = _promotivnaPonudaService.Add(promotivnaPonuda);

            if (result.IsSuccess)
            {
                MessageBox.Show("Promotivna ponuda uspešno dodata.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
