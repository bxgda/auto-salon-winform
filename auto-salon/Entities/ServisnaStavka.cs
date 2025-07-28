namespace auto_salon.Entities;

public class ServisnaStavka
{
    public virtual required int ID { get; set; }
    public virtual required Vozilo Vozilo { get; set; }
    public virtual DateTime Datum { get; set; }
    public virtual string Opis { get; set; }
}