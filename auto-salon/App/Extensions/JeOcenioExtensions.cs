using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class JeOcenioExtensions
    {
        public static JeOcenioDTO ToJeOcenioDTO(this JeOcenio ocena) 
        {
            // Osnovni podaci
            var dto = new JeOcenioDTO
            {
                ID = ocena.ID,
                Ocena = ocena.Ocena,
                IdKupca = ocena.Kupac.ID
            };

            // Kupac
            if (ocena.Kupac.FizickoLice != null)
            {
                dto.TipKupca = "Fizicko lice";
                dto.ImeKupca = ocena.Kupac.FizickoLice.Ime;
                dto.PrezimeKupca = ocena.Kupac.FizickoLice.Prezime;
                dto.EmailKupca = ocena.Kupac.FizickoLice.Email;
                dto.TelefonKupca = ocena.Kupac.FizickoLice.KontaktTelefon;
                dto.AdresaKupca = ocena.Kupac.FizickoLice.Adresa;
            }
            else if (ocena.Kupac.PravnoLice != null)
            {
                dto.TipKupca = "Pravno lice";
                dto.PIBKupca = ocena.Kupac.PravnoLice.PIB;
                dto.NazivFirmeKupca = ocena.Kupac.PravnoLice.NazivFirme;
                dto.SedisteFirmeKupca = ocena.Kupac.PravnoLice.Sediste;
                dto.KontaktOsobaFirme = ocena.Kupac.PravnoLice.KontaktOsoba;
            }

            // Prodavac
            dto.ImeProdavca = ocena.Prodavac.Ime;
            dto.PrezimeProdavca = ocena.Prodavac.Prezime;
            dto.PozicijaProdavca = ocena.Prodavac.Pozicija;
            dto.TelefonProdavca = ocena.Prodavac.KontaktTelefon;

            return dto;
        }
    }
}
