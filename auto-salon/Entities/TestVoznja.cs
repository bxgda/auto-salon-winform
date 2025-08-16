namespace auto_salon.Entities
{
    public class TestVoznja
    {
        public virtual int ID { get; protected set; }

        public virtual DateTime Datum { get; set; } = DateTime.Now;

        public virtual required string Vreme { get; set; }

        public virtual required decimal Ocena { get; set; }

        public virtual string? Zakljucak { get; set; }
        
        public virtual required Vozilo Vozilo { get; set; }

        public virtual required Kupac Kupac { get; set; }

        public virtual required Zaposleni Zaposleni { get; set; }
    }
}
