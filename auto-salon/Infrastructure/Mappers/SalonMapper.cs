using FluentNHibernate.Mapping;
using auto_salon.Entities;

namespace auto_salon.Infrastructure.Mappers
{
    public class SalonMapper : ClassMap<Salon>
    {
        public SalonMapper()
        {
            Table("SALON");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            DiscriminateSubClassesOnColumn("TIP");

            Map(x => x.Drzava).Column("DRZAVA");
            Map(x => x.Grad).Column("GRAD");
            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.RadnoVreme).Column("RADNO_VREME");
            Map(x => x.KontaktTelefon).Column("KONTAKT_TELEFON");
            Map(x => x.BrojZaposlenih).Column("BROJ_ZAPOSLENIH");

            HasMany(x => x.Zaposleni).KeyColumn("ID_SALONA").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Vozila).KeyColumn("ID_SALONA").LazyLoad().Cascade.All().Inverse();
        }
    }
    public class SalonNovaMapper : SubclassMap<SalonNova>
    {
        public SalonNovaMapper()
        {
            DiscriminatorValue("NOVA");

            HasManyToMany(x => x.Proizvodjaci)
                .Table("NUDI")
                .ParentKeyColumn("ID_SALONA")
                .ChildKeyColumn("ID_PROIZVODJACA");
                //.Cascade.All(); // Kada se obrise salon ne brisemo proizvodjace, samo se uklanja veza automatski iz NUDI
        }
    }

    public class SalonPolovnaMapper : SubclassMap<SalonPolovna>
    {
        public SalonPolovnaMapper()
        {
            DiscriminatorValue("POLOVNA");
        }
    }

    public class SalonKombinovanMapper : SubclassMap<SalonKombinovan>
    {
        public SalonKombinovanMapper()
        {
            DiscriminatorValue("KOMBINOVANA");
        }
    }
}
