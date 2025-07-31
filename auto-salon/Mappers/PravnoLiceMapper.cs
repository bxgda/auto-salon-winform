using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace AutoSalonMac.Mappers
{
    public class PravnoLiceMapper : ClassMap<PravnoLice>
    {
        public PravnoLiceMapper()
        {
            Table("PRAVNO_LICE");

            Id(x => x.PIB).Column("PIB");

            Map(x => x.NazivFirme).Column("NAZIV_FIRME");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.Sediste).Column("SEDISTE");
            Map(x => x.KontaktOsoba).Column("KONTAKT_OSOBA");

            References(x => x.Kupac).Column("ID_KUPCA").Unique().Cascade.All();
        }
    }
}