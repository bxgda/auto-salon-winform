using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Infrastructure.Mappers
{
    public class PromotivnaPonudaMapper : ClassMap<PromotivnaPonuda>
    {
        public PromotivnaPonudaMapper()
        {
            Table("PROMOTIVNA_PONUDA");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumOd).Column("DATUM_OD");
            Map(x => x.DatumDo).Column("DATUM_DO");
            Map(x => x.NazivPromocije).Column("NAZIV_PROMOCIJE");
            Map(x => x.PopustUProcentima).Column("POPUST_PROCENAT");
            Map(x => x.Uslovi).Column("USLOVI");

            References(x => x.Vozilo).Column("BROJ_SASIJE").LazyLoad();
        }
    }
}
