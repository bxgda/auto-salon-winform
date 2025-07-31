using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Mappers
{
    public class JeOcenioMapper : ClassMap<JeOcenio>
    {
        public JeOcenioMapper()
        {
            Table("JE_OCENIO");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ocena).Column("OCENA");

            References(x => x.Kupac).Column("ID_KUPCA").LazyLoad();
            References(x => x.Prodavac).Column("JMBG_PRODAVCA").LazyLoad();
        }
    }
}
