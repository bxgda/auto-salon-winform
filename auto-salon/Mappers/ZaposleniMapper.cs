using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Mappers
{
    // TODO: Mapirati i ULOGA jer nemamo posebne klase za sve izvedene entitete
    // kako bi izbegli duboko nasledjivanje
    public class ZaposleniMapper : SubclassMap<Zaposleni>
    {
        public ZaposleniMapper()
        {
            Table("ZAPOSLENI");

            KeyColumn("JMBG");

            Map(x => x.Pozicija).Column("POZICIJA");
            Map(x => x.DatumZaposlenja).Column("DATUM_ZAPOSLENJA");
            
            References(x => x.Salon, "ID_SALONA");
        }
    }
}
