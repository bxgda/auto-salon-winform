using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto_salon.Entities
{
    public class Salon
    {
        public virtual int ID { get; protected set; }
        public virtual required string Drzava { get; set; } 
        public virtual required string Grad { get; set; }
        public virtual required string Adresa { get; set; }
        public virtual required string Naziv { get; set; }
        public virtual DateTime RadnoVreme { get; set; }
        public virtual required string KontaktTelefon { get; set; }
        public virtual int BrojZaposlenih { get; set; }
        public virtual int FSalonNova { get; set; }
        public virtual int FSalonPolovna { get; set; }
    }
}
