using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Mappers
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
                .ChildKeyColumn("ID_SALONA")
                .Cascade.All();

            HasMany(x => x.Vozila).KeyColumn("ID_PROIZVODJACA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
