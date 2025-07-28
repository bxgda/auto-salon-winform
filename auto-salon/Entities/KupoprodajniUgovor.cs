namespace auto_salon.Entities
{
    public enum NacinPlacanja
    {
        GOTOVINA,
        KREDIT,
        LIZING
    }

    public class KupoprodajniUgovor
    {
        public virtual int ID { get; protected set; }
        public virtual required NacinPlacanja NacinPlacanja { get; set; }
        public virtual string? DodatnaOprema { get; set; }
        public virtual decimal KonacnaOcena { get; set; } = 0;
        public virtual decimal OcenaProdavca { get; set; } = 0;

        public virtual required Prodavac Prodavac { get; set; }
        public virtual required Kupac Kupac { get; set; }
        public virtual required Vozilo Vozilo { get; set; }
    }
}
