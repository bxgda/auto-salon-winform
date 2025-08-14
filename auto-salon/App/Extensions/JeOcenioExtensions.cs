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
                dto.JMBGKupca = ocena.Kupac.FizickoLice.JMBG;
                dto.ImeKupca = ocena.Kupac.FizickoLice.Ime;
                dto.PrezimeKupca = ocena.Kupac.FizickoLice.Prezime;
            }
            else if (ocena.Kupac.PravnoLice != null)
            {
                dto.TipKupca = "Pravno lice";
                dto.PIBKupca = ocena.Kupac.PravnoLice.PIB;
                dto.NazivFirmeKupca = ocena.Kupac.PravnoLice.NazivFirme;
            }

            // Prodavac
            dto.JMBGProdavca = ocena.Prodavac.JMBG;
            dto.ImeProdavca = ocena.Prodavac.Ime;
            dto.PrezimeProdavca = ocena.Prodavac.Prezime;
            
            return dto;
        }
    }
}
