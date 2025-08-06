using auto_salon.App.DTOs;
using auto_salon.Entities;

namespace AutoSalonMac.App.Extensions
{
    public static class VoziloExtension
    {
        public static VoziloTableDTO ToVoziloTableDTO(this Vozilo vozilo)
        {
            if (vozilo.GetType().Name == "NovoVozilo")
                return new VoziloTableDTO
                {
                    Stanje = "Novo",
                    BrojSasije = vozilo.BrojSasije,
                    Model = vozilo.Model,
                    NazivProizvodjaca = vozilo.Proizvodjac.Naziv,
                    Boja = vozilo.Boja,
                    BrojVrata = vozilo.BrojVrata,
                    TipGoriva = vozilo.TipGoriva,
                    SnagaMotora = vozilo.SnagaMotora,
                    Kilometraza = vozilo.Kilometraza,
                    GodinaProizvodnje = vozilo.GodinaProizvodnje,
                    JeProdato = vozilo.Ugovor != null,
                };
            else
                return new VoziloTableDTO
                {
                    Stanje = "Polovno",
                    BrojSasije = vozilo.BrojSasije,
                    Model = vozilo.Model,
                    NazivProizvodjaca = vozilo.Proizvodjac.Naziv,
                    Boja = vozilo.Boja,
                    BrojVrata = vozilo.BrojVrata,
                    TipGoriva = vozilo.TipGoriva,
                    SnagaMotora = vozilo.SnagaMotora,
                    Kilometraza = vozilo.Kilometraza,
                    GodinaProizvodnje = vozilo.GodinaProizvodnje,
                    BrojVlasnika = (vozilo as PolovnoVozilo)!.BrojVlasnika,
                    DatumRegistracije = (vozilo as PolovnoVozilo)!.DatumRegistracije,
                    JeProdato = vozilo.Ugovor != null
                };
        }

        public static Vozilo CreateNewEntity(this VoziloTableDTO vozilo, Salon salon, Proizvodjac proizvodjac)
        {

            if (vozilo.Stanje == "Novo")
                return new NovoVozilo
                {
                    BrojSasije = vozilo.BrojSasije,
                    Model = vozilo.Model,
                    Boja = vozilo.Boja,
                    BrojVrata = vozilo.BrojVrata,
                    TipGoriva = vozilo.TipGoriva,
                    SnagaMotora = vozilo.SnagaMotora,
                    Kilometraza = vozilo.Kilometraza,
                    GodinaProizvodnje = vozilo.GodinaProizvodnje,
                    Salon = salon,
                    Proizvodjac = proizvodjac
                };
            else
                return new PolovnoVozilo
                {
                    BrojSasije = vozilo.BrojSasije,
                    Model = vozilo.Model,
                    Boja = vozilo.Boja,
                    BrojVrata = vozilo.BrojVrata,
                    TipGoriva = vozilo.TipGoriva,
                    SnagaMotora = vozilo.SnagaMotora,
                    Kilometraza = vozilo.Kilometraza,
                    GodinaProizvodnje = vozilo.GodinaProizvodnje,
                    Salon = salon,
                    Proizvodjac = proizvodjac,
                    BrojVlasnika = vozilo.BrojVlasnika,
                    DatumRegistracije = vozilo.DatumRegistracije
                };
        }
    }
}