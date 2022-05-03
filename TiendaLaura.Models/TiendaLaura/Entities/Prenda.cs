using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaura.Models.TiendaLaura.Entities
{
    public class Prenda
    {
        public int PrendaId { get; set; } 
        public string? NombrePrenda { get; set; } 
        public bool? Estado { get; set; }

        //Propiedades de navegación y fk
        //[ForeignKey("TipoPrenda")] En el caso de que los id no coincidan con el nombre 

        public int? TipoPrendaId { get; set; }
        public virtual TipoPrenda TipoPrenda { get; set; }


        public int? ColorId { get; set; }
        public virtual Color Color { get; set; }

    }
}
