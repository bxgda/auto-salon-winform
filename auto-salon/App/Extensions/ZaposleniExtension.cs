using auto_salon.App.DTOs;
using auto_salon.App.Extensions;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class ZaposleniExtension
    {
        public static ZaposleniDTO ToZaposleniDTO(this Zaposleni zaposleni)
        {
            return new ZaposleniDTO
            {
                Pozicija = zaposleni.Pozicija,
                Uloga = zaposleni.Uloga,
                DatumPostavljenja = zaposleni.DatumPostavljenja,
                Ime = zaposleni.Ime,
                Prezime = zaposleni.Prezime,
                JMBG = zaposleni.JMBG,
                DatumZaposlenja = zaposleni.DatumZaposlenja,
                KontaktTelefon = zaposleni.KontaktTelefon,
                Email = zaposleni.Email,
                Adresa = zaposleni.Adresa,
                Kupac = zaposleni.Kupac?.ToKupacDTO()
            };
        }

        public static Zaposleni CreateNewEntity(this ZaposleniDTO zaposleniDto, Salon salon, Kupac? kupac = null)
        {
            return new Zaposleni
            {
                Pozicija = zaposleniDto.Pozicija,
                Uloga = zaposleniDto.Uloga,
                DatumPostavljenja = zaposleniDto.DatumPostavljenja,
                Ime = zaposleniDto.Ime,
                Prezime = zaposleniDto.Prezime,
                JMBG = zaposleniDto.JMBG,
                DatumZaposlenja = zaposleniDto.DatumZaposlenja,
                KontaktTelefon = zaposleniDto.KontaktTelefon,
                Email = zaposleniDto.Email,
                Adresa = zaposleniDto.Adresa,
                Salon = salon,
                Kupac = kupac
            };
        }
    }
}