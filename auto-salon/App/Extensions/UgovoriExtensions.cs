using auto_salon.App.DTOs;
using auto_salon.Entities;

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
                DodatnaOprema = ugovor.DodatnaOprema,
                KonacnaOcena = ugovor.KonacnaOcena,
                OcenaProdavca = ugovor.OcenaProdavca,
                BrojSasije = ugovor.Vozilo.BrojSasije, // dodatni upit se izvrsi
                JmbgProdavca = ugovor.Prodavac.JMBG,
                KupacId = ugovor.Kupac.ID,
            };
        }
    }
}
