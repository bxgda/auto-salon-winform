using auto_salon.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace auto_salon.Infrastructure.Mappers
{
    public class KupoprodajniUgovorMapper : ClassMap<KupoprodajniUgovor>
    {
        public KupoprodajniUgovorMapper()
        {
            Table("KUPOPRODAJNI_UGOVOR");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.NacinPlacanja).Column("NACIN_PLACANJA").CustomType<EnumStringType<NacinPlacanja>>();
            Map(x => x.DodatnaOprema).Column("DODATNA_OPREMA");
            Map(x => x.KonacnaOcena).Column("KONACNA_OCENA");
            Map(x => x.OcenaProdavca).Column("OCENA_PRODAVCA");
            Map(x => x.KonacnaCena).Column("KONACNA_CENA");

            References(x => x.Prodavac).Column("JMBG_PRODAVCA").LazyLoad();
            References(x => x.Kupac).Column("ID_KUPCA").LazyLoad();
            References(x => x.Vozilo).Column("BROJ_SASIJE").LazyLoad();
        }
    }
}
