using auto_salon.App.DTOs;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FProizvodjacNudi
{
    public partial class EditProizvodjac : Form
    {
        private readonly IProizvodjacService _proizvodjacService;
        private ProizvodjacDTO _proizvodjacDto;

        public EditProizvodjac(IProizvodjacService proizvodjacService, ProizvodjacDTO proizvodjacDto)
        {
            InitializeComponent();
            _proizvodjacService = proizvodjacService;
            _proizvodjacDto = proizvodjacDto;

            LoadUIWithData();
        }

        private void LoadUIWithData()
        {
            tbxNaziv.Text = _proizvodjacDto.Naziv;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNaziv.Text))
            {
                MessageBox.Show("Molimo unesite naziv proizvođača.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNaziv.Focus();
                return;
            }

            _proizvodjacDto.Naziv = tbxNaziv.Text;

            var result = _proizvodjacService.Update(_proizvodjacDto);

            if (result.IsSuccess)
            {
                MessageBox.Show("Proizvođač uspešno ažuriran.", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
