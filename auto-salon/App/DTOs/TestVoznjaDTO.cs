namespace auto_salon.App.DTOs
{
    public class TestVoznjaDTO
    {

    }

    public class TestVoznjaCreateDTO
    {
        public DateTime Datum { get; set; } = DateTime.Now;

        public required string Vreme { get; set; }

        public required decimal Ocena { get; set; }

        public string? Zakljucak { get; set; }

        public required string BrojSasije { get; set; }
        
        public required string JmbgZaposlenog { get; set; }
        
        public string? JmbgFizickogKupca { get; set; }

        public string? PIBPravnogKupca { get; set; }
    }
}
