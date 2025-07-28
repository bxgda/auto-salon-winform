namespace auto_salon.Entities
{
    public class ServisnaStavka
    {
        public virtual required int ID { get; set; }

        public virtual required DateTime Datum { get; set; }

        public virtual required string Opis { get; set; }

        public virtual required Vozilo Vozilo { get; set; }
    }
}