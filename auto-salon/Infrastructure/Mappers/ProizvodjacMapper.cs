using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Infrastructure.Mappers
{
    public class ProizvodjacMapper : ClassMap<Proizvodjac>
    {
        public ProizvodjacMapper()
        {
            Table("PROIZVODJAC");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv).Column("NAZIV");

            HasManyToMany(x => x.Saloni)
                .Table("NUDI")
                .ParentKeyColumn("ID_PROIZVODJACA")
                .ChildKeyColumn("ID_SALONA");
                //.Cascade.All(); // Kada se obrise proizvodjac ne brisemo salone, samo se uklanja veza iz NUDI tabele

            HasMany(x => x.Vozila).KeyColumn("ID_PROIZVODJACA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
