using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaura.Models.TiendaLaura.Entities
{
    public class Color
    {
        public int ColorId { get; set; } 
        public string? NombreColor { get; set; } 

        public virtual ICollection<Prenda>? Prendas { get; set; }
    }
}
