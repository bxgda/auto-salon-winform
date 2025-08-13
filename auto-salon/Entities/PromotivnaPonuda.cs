namespace auto_salon.Entities
{
    public class PromotivnaPonuda
    {
        public virtual int ID { get; set; }

        public virtual DateTime DatumOd { get; set; }

        public virtual DateTime DatumDo { get; set; }

        public virtual required string NazivPromocije { get; set; }

        public virtual required decimal PopustUProcentima { get; set; }

        public virtual required string Uslovi { get; set; }

        public virtual IList<Vozilo> Vozila { get; set; }

        public PromotivnaPonuda()
        {
            Vozila = new List<Vozilo>();
        }
    }
}
