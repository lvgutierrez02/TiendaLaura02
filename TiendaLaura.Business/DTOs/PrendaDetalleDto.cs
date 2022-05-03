using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaura.Business.DTOs
{
    public class PrendaDetalleDto
    {
        public int PrendaId { get; set; }

        [DisplayName("Nombre")]
        public string? NombrePrenda { get; set; }
        public bool? Estado { get; set; }

        [DisplayName("Tipo de prenda")]
        public string? TipoPrenda { get; set; }

        [DisplayName("Color de la prenda")]
        public string? Color { get; set; }

    }
}
