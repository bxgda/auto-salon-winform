using auto_salon.Presentation.FSalon;

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
    }
}
