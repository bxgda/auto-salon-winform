using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Mappers
{
    internal class ProizvodjacMapper : ClassMap<Proizvodjac>
    {
        public ProizvodjacMapper()
        {
            Table("PROIZVODJAC");
            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv).Column("NAZIV");

            //TODO odraditi veze sa drugim entitetima
        }
    }
}
