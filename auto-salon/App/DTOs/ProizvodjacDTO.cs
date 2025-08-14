namespace auto_salon.App.DTOs
{
    public class ProizvodjacDTO
    {
        public int ID { get; set; }

        public required string Naziv { get; set; }

        public IList<SalonDTO> Saloni { get; set; } = [];
    }
}
