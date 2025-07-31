using auto_salon.Entities;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace auto_salon.Mappers
{
    public class VoziloMapper : ClassMap<Vozilo>
    {
        public VoziloMapper() 
        {
            Table("VOZILO");

            Id(x => x.BrojSasije).Column("BROJ_SASIJE");

            DiscriminateSubClassesOnColumn("STANJE");

            Map(x => x.Model).Column("MODEL");
            Map(x => x.TipGoriva).Column("TIP_GORIVA").CustomType<EnumStringType<TipGoriva>>();
            Map(x => x.Kilometraza).Column("KILOMETRAZA");
            Map(x => x.BrojVrata).Column("BROJ_VRATA");
            Map(x => x.SnagaMotora).Column("SNAGA_MOTORA");
            Map(x => x.Boja).Column("BOJA");
            Map(x => x.GodinaProizvodnje).Column("GODINA_PROIZVODNJE");

            References(x => x.Proizvodjac).Column("ID_PROIZVODJACA").LazyLoad();
            References(x => x.Salon).Column("ID_SALONA").LazyLoad();

            HasOne(x => x.Ugovor).PropertyRef(x => x.Vozilo);

            HasMany(x => x.PromotivnePonude).KeyColumn("BROJ_SASIJE").Inverse().Cascade.All().LazyLoad();
            HasMany(x => x.TestVoznje).KeyColumn("BROJ_SASIJE").Inverse().Cascade.All().LazyLoad();
        }
    }

    public class PolovnoVoziloMapper : SubclassMap<PolovnoVozilo>
    {
        public PolovnoVoziloMapper()
        {
            DiscriminatorValue("POLOVNO");

            Map(x => x.DatumRegistracije).Column("DATUM_REGISTRACIJE");
            Map(x => x.BrojVlasnika).Column("BROJ_VLASNIKA");
            
            HasMany(x => x.ServisnaIstorija).KeyColumn("BROJ_SASIJE").Inverse().Cascade.All().LazyLoad();
        }
    }

    public class NovoVoziloMapper : SubclassMap<NovoVozilo>
    {
        public NovoVoziloMapper()
        {
            DiscriminatorValue("NOVO");
        }
    }
}
