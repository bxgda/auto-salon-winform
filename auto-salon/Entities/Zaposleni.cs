namespace auto_salon.Entities
{
    public class Zaposleni : FizickoLice
    {
        public virtual required string Pozicija { get; set; }
        public virtual required DateTime DatumZaposlenja { get; set; } = DateTime.Now;
        public virtual required Salon Salon { get; set; }
    }

    public class Menadzer : Zaposleni
    {
        public virtual DateTime DatumPostavljenja { get; set; }
    }

    public class FinansijskiSavetnik : Zaposleni { }

    public class  Serviser : Zaposleni { }

    public class Prodavac : Zaposleni
    {
        public virtual IList<KupoprodajniUgovor> Ugovori { get; set; }

        public virtual IList<JeOcenio> JeOcenjenKupci { get; set; }

        public Prodavac()
        {
            Ugovori = new List<KupoprodajniUgovor>();
            JeOcenjenKupci = new List<JeOcenio>();
        }
    }
}
