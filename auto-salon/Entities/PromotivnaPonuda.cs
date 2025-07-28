namespace auto_salon.Entities
{
    public class PromotivnaPonuda
    {
        public virtual int ID { get; protected set; }

        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime DatumDo { get; set; }

        public virtual required string NazivPromocije { get; set; }

        public virtual required decimal PopustUProcentima { get; set; }

        public virtual required string Uslovi { get; set; }

        public virtual required Vozilo Vozilo { get; set; }
    }
}
