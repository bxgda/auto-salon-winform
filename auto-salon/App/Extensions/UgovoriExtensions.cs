using auto_salon.App.DTOs;
using auto_salon.Entities;
using AutoSalonMac.App.Extensions;

namespace auto_salon.App.Extensions
{
    public static class UgovoriExtensions
    {
        public static UgovorTableDTO ToUgovorTableDTO(this KupoprodajniUgovor ugovor)
        {
            return new UgovorTableDTO
            {
                ID = ugovor.ID,
                NacinPlacanja = ugovor.NacinPlacanja,
                DodatnaOprema = ugovor.DodatnaOprema ?? string.Empty,
                KonacnaOcena = ugovor.KonacnaOcena,
                OcenaProdavca = ugovor.OcenaProdavca,
                BrojSasije = ugovor.Vozilo.BrojSasije, // dodatni upit se izvrsi
                JmbgProdavca = ugovor.Prodavac.JMBG,
                KupacId = ugovor.Kupac.ID,
            };
        }

        public static UgovorDTO ToUgovorDTO(this KupoprodajniUgovor ugovor)
        {
            return new UgovorDTO
            {
                ID = ugovor.ID,
                NacinPlacanja = ugovor.NacinPlacanja,
                DodatnaOprema = ugovor.DodatnaOprema ?? string.Empty,
                KonacnaOcena = ugovor.KonacnaOcena,
                OcenaProdavca = ugovor.OcenaProdavca,
                Vozilo = ugovor.Vozilo.ToVoziloTableDTO(),
                Prodavac = ugovor.Prodavac.ToZaposleniDTO(),
                Kupac = ugovor.Kupac.ToKupacDTO()
            };
        }
        public static UgovorDetailsDTO ToUgovorDetailsDTO(this KupoprodajniUgovor ugovor)
        {
            var dto = new UgovorDetailsDTO
            {
                ID = ugovor.ID,
                NacinPlacanja = ugovor.NacinPlacanja.ToString(),
                DodatnaOprema = ugovor.DodatnaOprema ?? string.Empty,
                KonacnaOcena = ugovor.KonacnaOcena,
                OcenaProdavca = ugovor.OcenaProdavca,

                ImeProdavca = ugovor.Prodavac.Ime,
                PrezimeProdavca = ugovor.Prodavac.Prezime,
                PozicijaProdavca = ugovor.Prodavac.Pozicija,
                TelefonProdavca = ugovor.Prodavac.KontaktTelefon,

                BrojSasije = ugovor.Vozilo.BrojSasije,
                Model = ugovor.Vozilo.Model,
                Boja = ugovor.Vozilo.Boja,
                BrojVrata = ugovor.Vozilo.BrojVrata,
                TipGoriva = ugovor.Vozilo.TipGoriva.ToString(),
                SnagaMotora = ugovor.Vozilo.SnagaMotora,
                Kilometraza = ugovor.Vozilo.Kilometraza,
                GodinaProizvodnje = ugovor.Vozilo.GodinaProizvodnje
            };

            // Tip kupca
            if (ugovor.Kupac.FizickoLice != null)
            {
                dto.TipKupca = "Fizicko lice";
                dto.ImeKupca = ugovor.Kupac.FizickoLice.Ime;
                dto.PrezimeKupca = ugovor.Kupac.FizickoLice.Prezime;
                dto.EmailKupca = ugovor.Kupac.FizickoLice.Email;
                dto.TelefonKupca = ugovor.Kupac.FizickoLice.KontaktTelefon;
                dto.AdresaKupca = ugovor.Kupac.FizickoLice.Adresa;
            }
            else if (ugovor.Kupac.PravnoLice != null)
            {
                dto.TipKupca = "Pravno lice";
                dto.PIBKupca = ugovor.Kupac.PravnoLice.PIB;
                dto.NazivFirmeKupca = ugovor.Kupac.PravnoLice.NazivFirme;
                dto.EmailKupca = ugovor.Kupac.PravnoLice.Email;
                dto.TelefonKupca = ugovor.Kupac.PravnoLice.Telefon;
                dto.SedisteFirmeKupca = ugovor.Kupac.PravnoLice.Sediste;
                dto.KontaktOsobaFirme = ugovor.Kupac.PravnoLice.KontaktOsoba;
            }

            // Novo/Polovno
            if (ugovor.Vozilo is NovoVozilo)
            {
                dto.StanjeVozila = "Novo";
            }
            else if (ugovor.Vozilo is PolovnoVozilo polovno)
            {
                dto.StanjeVozila = "Polovno";
                dto.DatumRegistracije = polovno.DatumRegistracije;
                dto.BrojVlasnika = polovno.BrojVlasnika;
            }

            return dto;
        }

    }

}
