using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class SalonExtensions
    {
        public static SalonDTO ToSalonDTO(this Salon salon)
        {
            return new SalonDTO
            {
                ID = salon.ID,
                Drzava = salon.Drzava,
                Grad = salon.Grad,
                Adresa = salon.Adresa,
                Naziv = salon.Naziv,
                RadnoVreme = salon.RadnoVreme,
                KontaktTelefon = salon.KontaktTelefon,
                BrojZaposlenih = salon.BrojZaposlenih,
                Tip = salon.GetType().Name switch
                {
                    "SalonNova" => "Nova",
                    "SalonPolovna" => "Polovna",
                    "SalonKombinovan" => "Kombinovan",
                    _ => "Nepoznat tip"
                }
            };
        }

        public static Salon CreateNewEntity(this SalonDTO salonDto)
        {
            switch (salonDto.Tip)
            {
                case "Nova":
                    return new SalonNova
                    {
                        Drzava = salonDto.Drzava,
                        Grad = salonDto.Grad,
                        Adresa = salonDto.Adresa,
                        Naziv = salonDto.Naziv,
                        RadnoVreme = salonDto.RadnoVreme,
                        KontaktTelefon = salonDto.KontaktTelefon,
                        BrojZaposlenih = salonDto.BrojZaposlenih
                    };
                case "Polovna":
                    return new SalonPolovna
                    {
                        Drzava = salonDto.Drzava,
                        Grad = salonDto.Grad,
                        Adresa = salonDto.Adresa,
                        Naziv = salonDto.Naziv,
                        RadnoVreme = salonDto.RadnoVreme,
                        KontaktTelefon = salonDto.KontaktTelefon,
                        BrojZaposlenih = salonDto.BrojZaposlenih
                    };
                // Kombinovan
                default:
                    return new SalonKombinovan
                    {
                        Drzava = salonDto.Drzava,
                        Grad = salonDto.Grad,
                        Adresa = salonDto.Adresa,
                        Naziv = salonDto.Naziv,
                        RadnoVreme = salonDto.RadnoVreme,
                        KontaktTelefon = salonDto.KontaktTelefon,
                        BrojZaposlenih = salonDto.BrojZaposlenih
                    };

            }
        }
    }
}
