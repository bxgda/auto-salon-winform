using auto_salon.Infrastructure.Mappers;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System.Configuration;

namespace auto_salon.Data
{
    public class DataLayer : IDataLayer
    {
        private readonly ISessionFactory _sessionFactory;

        public DataLayer()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;

            var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ConnectionString(c => c.Is(connectionString));

            _sessionFactory = Fluently.Configure()
                .Database(cfg.ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SalonMapper>())
                .BuildSessionFactory();
        }

        public ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }
    }
}
