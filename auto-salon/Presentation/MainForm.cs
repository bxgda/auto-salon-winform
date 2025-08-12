using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FZaposleni;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FUgovori;
using Microsoft.Extensions.DependencyInjection;
using auto_salon.Presentation.FKupac;
using auto_salon.Entities;
using auto_salon.Presentation.FPromotivnePonude;

namespace auto_salon
{
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        private Button? _activeButton;
        private readonly Color _activeColor = Color.LightBlue;
        private readonly Color _defaultColor = SystemColors.Control;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;

            // Postavi neki naslov ili sliku ili oba u pnlContent
        }

        private void LoadControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(control);
        }

        private void SetActiveButton(Button clickedButton)
        {
            if (_activeButton != null)
                _activeButton.BackColor = _defaultColor;

            _activeButton = clickedButton;
            _activeButton.BackColor = _activeColor;
        }

        private void btnSaloni_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<SalonUC>();
            LoadControl(control);
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<ZaposleniUC>();
            LoadControl(control);
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<VoziloUC>();
            LoadControl(control);
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<UgovoriUC>();
            LoadControl(control);
        }

        private void btnKupci_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<KupacUC>();
            LoadControl(control);
        }

        private void btnPromotivnePonude_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<PromotivnaPonudaUC>();
            LoadControl(control);
        }
    }
}
