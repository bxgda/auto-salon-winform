using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using System.Configuration;
using auto_salon.Entities;

namespace StanNaDan;
static class DataLayer
{
    private static ISessionFactory? factory;
    private static object lockObj;

    static DataLayer()
    {
        factory = null;
        lockObj = new();
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
            // Read connection string from app.config
            string connStr = ConfigurationManager.ConnectionStrings["OracleCS"].ConnectionString;

            var cfg = OracleManagedDataClientConfiguration.Oracle10
                .ShowSql()
                .ConnectionString(c => c.Is(connStr));

            return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Salon>())
                .BuildSessionFactory();
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            return null;
        }
    }
}