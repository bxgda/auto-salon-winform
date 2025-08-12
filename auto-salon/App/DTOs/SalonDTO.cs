namespace auto_salon.App.DTOs
{
    public class SalonDTO
    {
        public int ID { get; set; }

        public required string Tip { get; set; }

        public required string Drzava { get; set; }

        public required string Grad { get; set; }

        public required string Adresa { get; set; }

        public required string Naziv { get; set; }

        public required string RadnoVreme { get; set; }

        public required string KontaktTelefon { get; set; }

        public int BrojZaposlenih { get; set; }
    }

    public class SalonComboboxDTO
    {
        public int ID { get; set; }
        
        public required string Naziv { get; set; }
    }
}
