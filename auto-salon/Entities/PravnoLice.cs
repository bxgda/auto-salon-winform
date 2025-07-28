namespace auto_salon.Entities
{
    public class PravnoLice
    {
        public virtual required string PIB { get; set; }

        public virtual required string NazivFirme{ get; set; }

        public virtual string? Email { get; set; } // u sql smo stavili da je notnull

        public virtual required string Telefon{ get; set; }

        public virtual required string Sediste{ get; set; }

        public virtual string KontaktOsoba { get; set; }

        public virtual Kupac Kupac { get; set; }
    }
}
