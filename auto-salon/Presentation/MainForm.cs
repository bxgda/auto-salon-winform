using auto_salon.Presentation;
using auto_salon.Presentation.FKupac;
using auto_salon.Presentation.FOcene;
using auto_salon.Presentation.FProizvodjacNudi;
using auto_salon.Presentation.FPromotivnePonude;
using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FTestVoznja;
using auto_salon.Presentation.FUgovori;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FZaposleni;
using Microsoft.Extensions.DependencyInjection;
using System.Media;

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
            var control = _serviceProvider.GetRequiredService<Home>();
            LoadControl(control);
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

        private void btnOcene_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<OceneUC>();
            LoadControl(control);
        }

        private void btnProizvodjacNudi_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
            var control = _serviceProvider.GetRequiredService<ProizvodjacNudiUC>();
            LoadControl(control);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<TestVoznjaUC>();
            LoadControl(control);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var control = _serviceProvider.GetRequiredService<Home>();
            LoadControl(control);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer player = new SoundPlayer(Properties.Resources.open_sound);
                player.Play();
            }
            catch (Exception ex) { }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            var player = new SoundPlayer(Properties.Resources.car_lock_sound);
            player.PlaySync();

            e.Cancel = false;
        }
    }
}
