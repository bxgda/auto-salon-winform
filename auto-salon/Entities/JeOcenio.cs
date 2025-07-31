namespace auto_salon.Entities
{
    public class JeOcenio
    {
        public virtual int ID { get; protected set; }

        public virtual required decimal Ocena { get; set; }

        public virtual required Kupac Kupac { get; set; }

        public virtual required FizickoLice Prodavac { get; set; }
    }
}
