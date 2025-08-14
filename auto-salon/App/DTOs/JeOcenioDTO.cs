namespace auto_salon.App.DTOs
{
    public class JeOcenioDTO
    {
        public int ID { get; set; }
        public decimal Ocena { get; set; }
        public int IdKupca { get; set; }

        // Podaci o kupcu
        public string TipKupca { get; set; } = string.Empty; // Fizicko lice / Pravno lice

        // Fizičko lice
        public string? ImeKupca { get; set; }
        public string? PrezimeKupca { get; set; }
        public string? EmailKupca { get; set; }
        public string? TelefonKupca { get; set; }
        public string? AdresaKupca { get; set; }

        // Pravno lice
        public string? PIBKupca { get; set; }
        public string? NazivFirmeKupca { get; set; }
        public string? SedisteFirmeKupca { get; set; }
        public string? KontaktOsobaFirme { get; set; }

        // Podaci o prodavcu
        public string ImeProdavca { get; set; } = string.Empty;
        public string PrezimeProdavca { get; set; } = string.Empty;
        public string PozicijaProdavca { get; set; } = string.Empty;
        public string TelefonProdavca { get; set; } = string.Empty;
    }
}
