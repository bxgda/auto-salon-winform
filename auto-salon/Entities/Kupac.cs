namespace auto_salon.Entities
{
    public class Kupac
    {
        public virtual int ID { get; protected set; }

        public virtual FizickoLice? FizickoLice { get; set; }
        
        public virtual PravnoLice? PravnoLice { get; set; }

        public virtual IList<KupoprodajniUgovor> KupoprodajniUgovori { get; set; }
        
        public virtual IList<JeOcenio> JeOcenioProdavci { get; set; }

        public Kupac()
        {
            KupoprodajniUgovori = new List<KupoprodajniUgovor>();
            JeOcenioProdavci = new List<JeOcenio>();
        }
    }
}
