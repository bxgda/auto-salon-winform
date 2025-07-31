using auto_salon.Entities;
using NHibernate;
using StanNaDan;
using System.Diagnostics;

namespace auto_salon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            ISession? session = null;

            try
            {
                session = DataLayer.GetSession();

                if (session == null)
                {
                    MessageBox.Show("Nije moguce uspostaviti vezu sa bazom podataka.");
                    return;
                }

                KupoprodajniUgovor ss = session.Load<KupoprodajniUgovor>(2);

                MessageBox.Show(ss.Kupac.PravnoLice?.PIB);

                session.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
