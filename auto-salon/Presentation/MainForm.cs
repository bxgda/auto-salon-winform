using auto_salon.Presentation.FSalon;
using auto_salon.Presentation.FZaposleni;
using auto_salon.Presentation.FVozilo;
using auto_salon.Presentation.FUgovori;

namespace auto_salon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Postavi neki naslov ili sliku ili oba u pnlContent
        }

        private void btnSaloni_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new SalonUC());
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new ZaposleniUC());
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new VoziloUC());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(new UgovoriUC());
        }
    }
}
