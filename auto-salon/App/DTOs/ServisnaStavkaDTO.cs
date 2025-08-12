namespace auto_salon.App.DTOs
{
    public class ServisnaStavkaDTO
    {
        public int ID { get; set; }

        public required DateTime Datum { get; set; }

        public required string Opis { get; set; }
    }
}
