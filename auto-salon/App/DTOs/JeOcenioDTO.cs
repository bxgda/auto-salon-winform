namespace auto_salon.App.DTOs
{
    public class JeOcenioDTO
    {
        public int ID { get; set; }

        public decimal Ocena { get; set; }

        public int IdKupca { get; set; }

        // Kupac
        public string TipKupca { get; set; } = string.Empty;

        // Fizicko lice
        public string? JMBGKupca { get; set; }
        
        public string? ImeKupca { get; set; }

        public string? PrezimeKupca { get; set; }

        // Pravno lice
        public string? PIBKupca { get; set; }
        
        public string? NazivFirmeKupca { get; set; }

        // Prodavac
        public string JMBGProdavca { get; set; } = string.Empty;
        
        public string ImeProdavca { get; set; } = string.Empty;

        public string PrezimeProdavca { get; set; } = string.Empty;
    }
}
