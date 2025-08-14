using auto_salon.App.DTOs;

namespace auto_salon.Presentation.FPromotivnePonude
{
    public partial class EditPromotivnaPonuda : Form
    {
        private PromotivnaPonudaDTO _ponudaDto;

        public EditPromotivnaPonuda(PromotivnaPonudaDTO ponudaDto)
        {
            InitializeComponent();
            _ponudaDto = ponudaDto;
        }
    }
}
