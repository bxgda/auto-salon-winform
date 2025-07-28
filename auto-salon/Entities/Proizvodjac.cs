namespace auto_salon.Entities
{
    public class Proizvodjac
    {
        public virtual int ID { get; protected set; }

        public virtual required string Naziv { get; set; }

        public virtual IList<Vozilo> Vozila { get; set; }

        public virtual IList<SalonNova> Saloni { get; set; }

        public Proizvodjac()
        {
            Vozila = new List<Vozilo>();
            Saloni = new List<SalonNova>();
        }
    }
}
