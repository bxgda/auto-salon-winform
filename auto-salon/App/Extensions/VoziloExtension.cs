using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class VoziloExtension
    {

        //NOVO VOZILO
        public static NovoVoziloTableDTO ToVoziloNovoTableDTO(this NovoVozilo vozilo)
        {
            return new NovoVoziloTableDTO
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

        public static NovoVozilo VoziloNovoToEntity(this NovoVoziloTableDTO voziloDto)
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
        public static PolovnoVoziloTableDTO ToVoziloPolovnoTableDTO(this PolovnoVozilo vozilo)
        {
            return new PolovnoVoziloTableDTO
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

        public static PolovnoVozilo VoziloPolovnoToEntity(this PolovnoVoziloTableDTO voziloDto)
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