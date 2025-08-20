using auto_salon.Data;

namespace auto_salon.Presentation
{
    public partial class Home : UserControl
    {
        private readonly IDataLayer _dataLayer;

        public Home(IDataLayer dataLayer)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Kratak poziv ka bazi da nema delay sa prvom interakcijom (malo ga fejkujemooooo)
            _dataLayer = dataLayer;
            var session = _dataLayer.OpenSession();
            session.Close();
        }
    }
}
