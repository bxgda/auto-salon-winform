namespace auto_salon.Entities
{
    public class Vozilo
    {
        public virtual required string BrojSasije { get; set; }

        public virtual required string Model { get; set; } 

        public virtual required TipGoriva TipGoriva { get; set; }

        public virtual int Kilometraza { get; set; }

        public virtual int BrojVrata { get; set; }

        public virtual int SnagaMotora { get; set; }

        public virtual required string Boja { get; set; }

        public virtual int GodinaProizvodnje { get; set; }

        public virtual required Proizvodjac Proizvodjac { get; set; }

        public virtual required Salon Salon { get; set; }

        public virtual KupoprodajniUgovor? Ugovor { get; set; }

        public virtual IList<TestVoznja> TestVoznje { get; set; }

        public Vozilo()
        {
            TestVoznje = new List<TestVoznja>();
        }
    }

    public class PolovnoVozilo : Vozilo
    {
        public virtual DateTime DatumRegistracije { get; set; }

        public virtual int BrojVlasnika { get; set; }

        public virtual IList<ServisnaStavka> ServisnaIstorija { get; set; }

        public PolovnoVozilo()
        {
            ServisnaIstorija = new List<ServisnaStavka>();
        }
    }

    public class NovoVozilo : Vozilo { }

    public enum TipGoriva
    {
        DIZEL,
        BENZIN,
        ELEKTRICNI,
        HIDROGEN,
        PLIN,
        METAN,
        HIBRID
    }
}