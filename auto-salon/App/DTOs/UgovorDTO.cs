using auto_salon.Entities;

namespace auto_salon.App.DTOs
{
    public class UgovorTableDTO
    {
        public int ID { get; set; }

        public required NacinPlacanja NacinPlacanja { get; set; }

        public required string DodatnaOprema { get; set; }

        public decimal KonacnaOcena { get; set; }

        public decimal OcenaProdavca { get; set; }

        public decimal KonacnaCena { get; set; }

        public required string JmbgProdavca { get; set; }

        public required int KupacId { get; set; }

        public required string BrojSasije { get; set; }
    }

    public class UgovorCreateDTO
    {
        public required NacinPlacanja NacinPlacanja { get; set; }
        
        public string? DodatnaOprema { get; set; }
        
        public decimal KonacnaOcena { get; set; }

        public decimal OcenaProdavca { get; set; }

        public decimal KonacnaCena { get; set; } = 0; // for now

        public required string BrojSasije { get; set; }

        public required string JmbgProdavca { get; set; }

        public string? JmbgFizickogKupca { get; set; }

        public string? PIBPravnogKupca { get; set; }
    }

    public class UgovorDetailsDTO
    {
        // Osnovni podaci o ugovoru
        public int ID { get; set; }
        public string NacinPlacanja { get; set; } = string.Empty;
        public string DodatnaOprema { get; set; } = string.Empty;
        public decimal KonacnaOcena { get; set; }
        public decimal OcenaProdavca { get; set; }

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

        // Podaci o vozilu
        public string StanjeVozila { get; set; } = string.Empty; // Novo / Polovno
        public string BrojSasije { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Boja { get; set; } = string.Empty;
        public int BrojVrata { get; set; }
        public string TipGoriva { get; set; } = string.Empty;
        public int SnagaMotora { get; set; }
        public int Kilometraza { get; set; }
        public int GodinaProizvodnje { get; set; }

        // Dodatno za polovno vozilo
        public DateTime? DatumRegistracije { get; set; }
        public int? BrojVlasnika { get; set; }
    }
}
