using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaura.Models.TiendaLaura.Entities
{
    public class TipoPrenda
    {
        public int TipoPrendaId { get; set; } 
        public string? TipoPrendaNombre { get; set; }  

        public virtual ICollection<Prenda>? Prendas { get; set;}
    }
}
