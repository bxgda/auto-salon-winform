using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Infrastructure.Mappers
{
    public class FizickoLiceMapper : ClassMap<FizickoLice>
    {
        public FizickoLiceMapper()
        {
            Table("FIZICKO_LICE");

            Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.KontaktTelefon).Column("KONTAKT_TELEFON");
            Map(x => x.Adresa).Column("ADRESA");

            References(x => x.Kupac).Column("ID_KUPCA").Cascade.All();
        }
    }
}
