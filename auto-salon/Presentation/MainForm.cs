using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FZaposleni;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FUgovori;
using Microsoft.Extensions.DependencyInjection;
using auto_salon.Presentation.FKupac;

namespace auto_salon
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Postavi neki naslov ili sliku ili oba u pnlContent
        }

        private void btnSaloni_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<SalonUC>();
            LoadControl(control);
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<ZaposleniUC>();
            LoadControl(control);
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<VoziloUC>();
            LoadControl(control);
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<UgovoriUC>();
            LoadControl(control);
        }

        private void LoadControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(control);
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<KupacUC>();
            LoadControl(control);
        }
    }
}
