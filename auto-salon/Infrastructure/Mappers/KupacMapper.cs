using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Infrastructure.Mappers
{
    public class KupacMapper : ClassMap<Kupac>
    {
        public KupacMapper()
        {
            Table("KUPAC");

            Id(x => x.ID).Column("ID").GeneratedBy.SequenceIdentity("KUPAC_ID_SEQ");

            HasOne(x => x.FizickoLice).PropertyRef(x => x.Kupac).Cascade.All();

            HasOne(x => x.PravnoLice).PropertyRef(x => x.Kupac).Cascade.All();

            HasMany(x => x.KupoprodajniUgovori).KeyColumn("ID_KUPCA").LazyLoad().Cascade.All().Inverse();

            // Brisanjem kupca se automatski brisu i ocene koje je dao iz tabele JE_OCENIO
            HasManyToMany(x => x.JeOcenioProdavci)
                .Table("JE_OCENIO")
                .ParentKeyColumn("ID_KUPCA")
                .ChildKeyColumn("JMBG_PRODAVCA");

            HasMany(x => x.TestVoznje).KeyColumn("ID_KUPCA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
