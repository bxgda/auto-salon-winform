namespace auto_salon.Entities
{
    public class Salon
    {
        public virtual int ID { get; protected set; }

        public virtual required string Drzava { get; set; } 

        public virtual required string Grad { get; set; }

        public virtual required string Adresa { get; set; }

        public virtual required string Naziv { get; set; }

        public virtual DateTime RadnoVreme { get; set; }

        public virtual required string KontaktTelefon { get; set; }

        public virtual int BrojZaposlenih { get; set; }

        public virtual IList<Zaposleni> Zaposleni { get; set; }

        public virtual IList<Vozilo> Vozila { get; set; }

        public Salon()
        {
            Zaposleni = new List<Zaposleni>();
            Vozila = new List<Vozilo>();
        }
    }

    public class SalonNova : Salon
    {
        public virtual IList<Proizvodjac> Proizvodjaci { get; set; }

        public SalonNova()
        {
            Proizvodjaci = new List<Proizvodjac>();
        }
    }

    public class SalonPolovna : Salon { }

    public class SalonKombinovan : Salon { }
}
