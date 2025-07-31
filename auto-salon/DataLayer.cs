using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System.Configuration;
using auto_salon.Mappers;

namespace StanNaDan;
static class DataLayer
    {
        private static ISessionFactory? factory;
        private static object lockObj;

        static DataLayer()
        {
            factory = null;
            lockObj = new object();
        }

        public static ISession? GetSession()
        {
            if (factory == null)
            {
                lock (lockObj)
                {
                    if (factory == null)
                    {
                        factory = CreateSessionFactory();
                    }
                }
            }

            return factory?.OpenSession();
            }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10.ConnectionString(c => c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19095;Password=oracle-db-elfak"));

                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SalonMapper>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }

        }
}