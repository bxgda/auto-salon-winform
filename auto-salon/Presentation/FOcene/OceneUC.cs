using auto_salon.App.DTOs;
using auto_salon.App.Services.Implementation;
using auto_salon.App.Services.Interfaces;

namespace auto_salon.Presentation.FOcene
{
    public partial class OceneUC : UserControl
    {
        public readonly IJeOcenioService _jeOcenioService;
        private IList<JeOcenioDTO> _ocene = [];

        public OceneUC(IJeOcenioService jeOcenioService)
        {
            InitializeComponent();

            _jeOcenioService = jeOcenioService;

            DefineColumnNamesForList();
            LoadOcene();
        }

        private void DefineColumnNamesForList()
        {
            // lvFizickaLica
            lvFizickaLica.Columns.Add("JMBG");
            lvFizickaLica.Columns.Add("Ime");
            lvFizickaLica.Columns.Add("Prezime");

            // lvPravnaLica
            lvPravnaLica.Columns.Add("PIB");
            lvPravnaLica.Columns.Add("Naziv Firme");
        }

        private void LoadOcene()
        {
            var result = _jeOcenioService.GetAll();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.ErrorMessage, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ocene = result.Data!;
        }
    }
}
