using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class ZaposleniExtension
    {
        public static ZaposleniTableDTO ToZaposleniTableDTO(this Zaposleni zaposleni)
        {
            return new ZaposleniTableDTO
            {
                Pozicija = zaposleni.Pozicija,
                Uloga = zaposleni.Uloga,
                DatumPostavljenja = zaposleni.DatumPostavljenja,
                Salon = zaposleni.Salon,
                Ime = zaposleni.Ime,
                Prezime = zaposleni.Prezime,
                JMBG = zaposleni.JMBG,
                DatumZaposlenja = zaposleni.DatumZaposlenja,
                KontaktTelefon = zaposleni.KontaktTelefon,
                Kupac = zaposleni.Kupac
            };
        }
        public static Zaposleni ZaposleniTableToEntity(this ZaposleniTableDTO zaposleniDto)
        {
            return new Zaposleni
            { 
                Kupac = zaposleniDto.Kupac,
                KontaktTelefon = zaposleniDto.KontaktTelefon,
                JMBG = zaposleniDto.JMBG,
                Ime = zaposleniDto.Ime,
                Prezime = zaposleniDto.Prezime,
                Pozicija = zaposleniDto.Pozicija,
                DatumZaposlenja = zaposleniDto.DatumZaposlenja,
                Uloga = zaposleniDto.Uloga,
                DatumPostavljenja = zaposleniDto.DatumPostavljenja,
                Salon = zaposleniDto.Salon
            };
        }
    }
}