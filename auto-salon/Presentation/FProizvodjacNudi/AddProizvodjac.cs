using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FProizvodjacNudi
{
    public partial class AddProizvodjac : Form
    {
        private readonly IProizvodjacService _proizvodjacService;

        public AddProizvodjac(IProizvodjacService proizvodjacService)
        {
            InitializeComponent();
            _proizvodjacService = proizvodjacService;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv proizvođača.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNaziv.Focus();
                return;
            }

            ProizvodjacDTO proizvodjac = new ProizvodjacDTO
            {
                Naziv = tbxNaziv.Text.Trim(),
            };

            var result = _proizvodjacService.Add(proizvodjac);

            if (result.IsSuccess)
            {
                MessageBox.Show("Proizvođač uspešno dodat.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
