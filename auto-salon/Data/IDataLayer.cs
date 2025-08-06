using NHibernate;

namespace auto_salon.Data
{
    public interface IDataLayer
    {
        ISession OpenSession();
    }
}
