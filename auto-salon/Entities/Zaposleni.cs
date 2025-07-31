namespace auto_salon.Entities
{
    public class Zaposleni : FizickoLice
    {
        public virtual required string Pozicija { get; set; }

        public virtual required DateTime DatumZaposlenja { get; set; } = DateTime.Now;

        public virtual required Uloga Uloga { get; set; }

        public virtual DateTime DatumPostavljenja { get; set; }

        public virtual required Salon Salon { get; set; }

        public virtual IList<TestVoznja> TestVoznje { get; set; }

        public virtual IList<KupoprodajniUgovor>? Ugovori { get; set; }

        public virtual IList<JeOcenio>? JeOcenjenOdKupaca { get; set; }

        public Zaposleni()
        {
            TestVoznje = new List<TestVoznja>();
        }
    }

    public enum Uloga
    {
        MENADZER,
        FINANSIJSKI_SAVETNIK,
        SERVISER,
        PRODAVAC
    }
}
