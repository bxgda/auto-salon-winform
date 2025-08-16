using auto_salon.Entities;

namespace auto_salon.App.DTOs
{
    public class TestVoznjaTableDTO
    {
        public int ID { get; set; }

        public DateTime Datum { get; set; } = DateTime.Now;

        public required string Vreme { get; set; }

        public required decimal Ocena { get; set; }

        public string? Zakljucak { get; set; }

        public required string JmbgZaposlenog { get; set; }

        public required int KupacId { get; set; }

        public required string BrojSasije { get; set; }
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

    public class TestVoznjaDetailsDTO
    {
        // Osnovni podaci o test voznji
        public int ID { get; set; }

        public DateTime Datum { get; set; } = DateTime.Now;

        public required string Vreme { get; set; }

        public required decimal Ocena { get; set; }

        public string? Zakljucak { get; set; }

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

        // Podaci o zaposlenom
        public string ImeZaposlenog { get; set; } = string.Empty;
        public string PrezimeZaposlenog { get; set; } = string.Empty;
        public string PozicijaZaposlenog { get; set; } = string.Empty;
        public string TelefonZaposlenog { get; set; } = string.Empty;
        public Uloga UlogaZaposlenog { get; set; } 

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
