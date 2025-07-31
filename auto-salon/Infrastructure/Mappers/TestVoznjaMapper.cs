using auto_salon.Entities;
using FluentNHibernate.Mapping;

namespace auto_salon.Infrastructure.Mappers
{
    public class TestVoznjaMapper : ClassMap<TestVoznja>
    {
        public TestVoznjaMapper()
        {
            Table("TEST_VOZNJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Datum, "DATUM");
            Map(x => x.Vreme, "VREME");
            Map(x => x.Ocena, "OCENA");
            Map(x => x.Zakljucak, "ZAKLJUCAK");

            References(x => x.Vozilo, "BROJ_SASIJE");
            References(x => x.Kupac, "ID_KUPCA");
            References(x => x.Prodavac, "JMBG_PRODAVCA");
        }
    }
}
