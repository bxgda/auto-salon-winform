using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace AutoSalonMac.Mappers
{
    public class ServisnaStavkaMapper: ClassMap<ServisnaStavka>
    {
        public ServisnaStavkaMapper()
        {
            Table("SERVISNA_STAVKA");
            
            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();
            
            Map(x => x.Datum).Column("DATUM").Not.Nullable();
            Map(x => x.Opis).Column("OPIS").Not.Nullable();

            References(x => x.Vozilo).Column("BROJ_SASIJE").LazyLoad();
        }
    }
}