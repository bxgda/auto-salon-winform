using auto_salon.Entities;

namespace auto_salon.App.DTOs
{
    public class UgovorDTO
    {
        public int ID { get; set; }

        public required NacinPlacanja NacinPlacanja { get; set; }

        public string? DodatnaOprema { get; set; }

        public decimal KonacnaOcena { get; set; }

        public decimal OcenaProdavca { get; set; }

        public required VoziloDTO Vozilo { get; set; }
        
        public required ZaposleniDTO Prodavac { get; set; }

        public required KupacDTO Kupac { get; set; }
    }

    public class UgovorTableDTO
    {
        public int ID { get; set; }

        public required NacinPlacanja NacinPlacanja { get; set; }

        public required string DodatnaOprema { get; set; }

        public decimal KonacnaOcena { get; set; }

        public decimal OcenaProdavca { get; set; }

        public required string JmbgProdavca { get; set; }
        
        public required int KupacId { get; set; }

        public required string BrojSasije { get; set; }
    }
}
