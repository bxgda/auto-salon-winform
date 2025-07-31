using System.Configuration;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
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

        private static ISessionFactory? CreateSessionFactory()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;
                var cfg = OracleManagedDataClientConfiguration.Oracle10.ConnectionString(c => c.Is(connectionString));

                return Fluently.Configure()
                    .Database(cfg.ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SalonMapper>())
                    .BuildSessionFactory();
            }
            catch (Exception ec)
            {
                MessageBox.Show("Greska prilikom kreiranja sesije: " + ec.Message);
                return null;
        }

        }
}