using auto_salon.App.Services;
using auto_salon.Entities;
using NHibernate;
using System.Data;

namespace auto_salon.Presentation.FSalon
{
    public partial class SalonUC : UserControl
    {
        private readonly ISalonService _salonService;

        public SalonUC(ISalonService salonService)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _salonService = salonService;
            LoadData();
        }

        private void LoadData()
        {
            dgvSaloni.DataSource = null;
            var saloni = _salonService.GetAll();
            dgvSaloni.DataSource = saloni;
        }
    }
}
