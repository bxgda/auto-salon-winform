using auto_salon.Entities;

namespace auto_salon.App.DTOs
{
    public class VoziloTableDTO
    {
        public required string Stanje { get; set; }

        public required string BrojSasije { get; set; }

        public required string Model { get; set; }
        
        public string? NazivProizvodjaca { get; set; }

        public required string Boja { get; set; }

        public int BrojVrata { get; set; }

        public required TipGoriva TipGoriva { get; set; }

        public int SnagaMotora { get; set; }

        public int Kilometraza { get; set; }

        public int GodinaProizvodnje { get; set; }

        public int BrojVlasnika { get; set; }

        public DateTime DatumRegistracije { get; set; }

        public bool JeProdato { get; set; } = false;
    }
}
