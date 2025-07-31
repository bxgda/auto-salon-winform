using auto_salon.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace auto_salon.Infrastructure.Mappers
{
    public class ZaposleniMapper : SubclassMap<Zaposleni>
    {
        public ZaposleniMapper()
        {
            Table("ZAPOSLENI");

            KeyColumn("JMBG");

            Map(x => x.Pozicija).Column("POZICIJA");
            Map(x => x.DatumZaposlenja).Column("DATUM_ZAPOSLENJA");
            Map(x => x.Uloga).Column("ULOGA").CustomType<EnumStringType<Uloga>>();
            Map(x => x.DatumPostavljenja).Column("DATUM_POSTAVLJANJA");

            References(x => x.Salon).Column("ID_SALONA").LazyLoad();

            HasMany(x => x.TestVoznje).Table("TEST_VOZNJE").KeyColumn("JMBG_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Ugovori).Table("KUPOPRODAJNI_UGOVOR").KeyColumn("JMBG_PRODAVCA").LazyLoad().Cascade.All().Inverse();

            // Brisanjem zaposlenog se automatski brisu i ocene koje je dobio iz tabele JE_OCENIO
            HasManyToMany(x => x.JeOcenjenOdKupaca)
                .Table("JE_OCENIO")
                .ParentKeyColumn("JMBG_PRODAVCA")
                .ChildKeyColumn("ID_KUPCA");
        }
    }
}
