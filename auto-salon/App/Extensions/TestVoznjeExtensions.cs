using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace auto_salon.App.Extensions
{
    public static class TestVoznjeExtensions
    {
        public static TestVoznjaTableDTO ToTestVoznjaTableDTO(this TestVoznja testVoznja)
        {
            return new TestVoznjaTableDTO
            {
                ID = testVoznja.ID,
                Datum = testVoznja.Datum,
                Vreme = testVoznja.Vreme,
                Ocena = testVoznja.Ocena,
                Zakljucak = testVoznja.Zakljucak,
                JmbgZaposlenog = testVoznja.Zaposleni.JMBG,
                KupacId = testVoznja.Kupac.ID,
                BrojSasije = testVoznja.Vozilo.BrojSasije
            };
        }

        public static TestVoznjaDetailsDTO ToTestVoznjaDetailsDTO(this TestVoznja testVoznja)
        {
            var dto = new TestVoznjaDetailsDTO
            {
                ID = testVoznja.ID,
                Datum = testVoznja.Datum,
                Vreme = testVoznja.Vreme,
                Ocena = testVoznja.Ocena,
                Zakljucak = testVoznja.Zakljucak,

                ImeZaposlenog = testVoznja.Zaposleni.Ime,
                PrezimeZaposlenog = testVoznja.Zaposleni.Prezime,
                PozicijaZaposlenog = testVoznja.Zaposleni.Pozicija,
                TelefonZaposlenog = testVoznja.Zaposleni.KontaktTelefon,
                UlogaZaposlenog = testVoznja.Zaposleni.Uloga,

                BrojSasije = testVoznja.Vozilo.BrojSasije,
                Model = testVoznja.Vozilo.Model,
                Boja = testVoznja.Vozilo.Boja,
                BrojVrata = testVoznja.Vozilo.BrojVrata,
                TipGoriva = testVoznja.Vozilo.TipGoriva.ToString(),
                SnagaMotora = testVoznja.Vozilo.SnagaMotora,
                Kilometraza = testVoznja.Vozilo.Kilometraza,
                GodinaProizvodnje = testVoznja.Vozilo.GodinaProizvodnje
            };

            // Tip kupca
            if (testVoznja.Kupac.FizickoLice != null)
            {
                dto.TipKupca = "Fizicko lice";
                dto.ImeKupca = testVoznja.Kupac.FizickoLice.Ime;
                dto.PrezimeKupca = testVoznja.Kupac.FizickoLice.Prezime;
                dto.EmailKupca = testVoznja.Kupac.FizickoLice.Email;
                dto.TelefonKupca = testVoznja.Kupac.FizickoLice.KontaktTelefon;
                dto.AdresaKupca = testVoznja.Kupac.FizickoLice.Adresa;
            }
            else if (testVoznja.Kupac.PravnoLice != null)
            {
                dto.TipKupca = "Pravno lice";
                dto.PIBKupca = testVoznja.Kupac.PravnoLice.PIB;
                dto.NazivFirmeKupca = testVoznja.Kupac.PravnoLice.NazivFirme;
                dto.EmailKupca = testVoznja.Kupac.PravnoLice.Email;
                dto.TelefonKupca = testVoznja.Kupac.PravnoLice.Telefon;
                dto.SedisteFirmeKupca = testVoznja.Kupac.PravnoLice.Sediste;
                dto.KontaktOsobaFirme = testVoznja.Kupac.PravnoLice.KontaktOsoba;
            }

            // Novo/Polovno
            if (testVoznja.Vozilo is NovoVozilo)
            {
                dto.StanjeVozila = "Novo";
            }
            else if (testVoznja.Vozilo is PolovnoVozilo polovno)
            {
                dto.StanjeVozila = "Polovno";
                dto.DatumRegistracije = polovno.DatumRegistracije;
                dto.BrojVlasnika = polovno.BrojVlasnika;
            }

            return dto;
        }
    }
}
