using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class VoziloExtension
    {

        public static VoziloTableDTO ToVoziloTableDTO(this Vozilo vozilo)
        {
            return new VoziloTableDTO
            {
                Stanje = vozilo.GetType().Name switch
                {
                    "NovoVozilo" => "Novo",
                    "PolovnoVozilo" => "Polovno",
                    _ => "Nepoznato stanje"
                },
                BrojSasije = vozilo.BrojSasije,
                Proizvodjac = vozilo.Proizvodjac,
                Model = vozilo.Model,
                Boja = vozilo.Boja,
                BrojVrata = vozilo.BrojVrata,
                TipGoriva = vozilo.TipGoriva,
                SnagaMotora = vozilo.SnagaMotora,
                Kilometraza = vozilo.Kilometraza,
                GodinaProizvodnje = vozilo.GodinaProizvodnje
            };
        }

        //NOVO VOZILO
        public static NovoVoziloDTO ToVoziloNovoTableDTO(this NovoVozilo vozilo)
        {
            return new NovoVoziloDTO
            {
                Salon = vozilo.Salon,
                Proizvodjac = vozilo.Proizvodjac,
                Model = vozilo.Model,
                GodinaProizvodnje = vozilo.GodinaProizvodnje,
                Kilometraza = vozilo.Kilometraza,
                Boja = vozilo.Boja,
                BrojSasije = vozilo.BrojSasije,
                TipGoriva = vozilo.TipGoriva,
                SnagaMotora = vozilo.SnagaMotora,
                BrojVrata = vozilo.BrojVrata
            };
        }

        public static NovoVozilo VoziloNovoToEntity(this NovoVoziloDTO voziloDto)
        {
            return new NovoVozilo
            {
                Salon = voziloDto.Salon,
                Proizvodjac = voziloDto.Proizvodjac,
                Model = voziloDto.Model,
                GodinaProizvodnje = voziloDto.GodinaProizvodnje,
                Kilometraza = voziloDto.Kilometraza,
                Boja = voziloDto.Boja,
                BrojSasije = voziloDto.BrojSasije,
                TipGoriva = voziloDto.TipGoriva,
                SnagaMotora = voziloDto.SnagaMotora,
                BrojVrata = voziloDto.BrojVrata
            };
        }


        //POLOVNO VOZILO
        public static PolovnoVoziloDTO ToVoziloPolovnoTableDTO(this PolovnoVozilo vozilo)
        {
            return new PolovnoVoziloDTO
            {
                Salon = vozilo.Salon,
                Proizvodjac = vozilo.Proizvodjac,
                Model = vozilo.Model,
                GodinaProizvodnje = vozilo.GodinaProizvodnje,
                Kilometraza = vozilo.Kilometraza,
                Boja = vozilo.Boja,
                BrojSasije = vozilo.BrojSasije,
                TipGoriva = vozilo.TipGoriva,
                SnagaMotora = vozilo.SnagaMotora,
                BrojVrata = vozilo.BrojVrata,
                DatumRegistracije = vozilo.DatumRegistracije,
                BrojVlasnika = vozilo.BrojVlasnika
            };
        }

        public static PolovnoVozilo VoziloPolovnoToEntity(this PolovnoVoziloDTO voziloDto)
        {
            return new PolovnoVozilo
            {
                Salon = voziloDto.Salon,
                Proizvodjac = voziloDto.Proizvodjac,
                Model = voziloDto.Model,
                GodinaProizvodnje = voziloDto.GodinaProizvodnje,
                Kilometraza = voziloDto.Kilometraza,
                Boja = voziloDto.Boja,
                BrojSasije = voziloDto.BrojSasije,
                TipGoriva = voziloDto.TipGoriva,
                SnagaMotora = voziloDto.SnagaMotora,
                BrojVrata = voziloDto.BrojVrata,
                DatumRegistracije = voziloDto.DatumRegistracije,
                BrojVlasnika = voziloDto.BrojVlasnika
            };
        }
    }
}