namespace auto_salon.Entities
{
    public class FizickoLice
    {
        public virtual required int JMBG { get; set; }
        public virtual required string Ime { get; set; }
        public virtual required string Prezime { get; set; }
        public virtual string? Email { get; set; } 
        public virtual required string KontaktTelefon { get; set; }
        public virtual string? Adresa { get; set; }

        public virtual required Kupac Kupac { get; set; }
    }
}
