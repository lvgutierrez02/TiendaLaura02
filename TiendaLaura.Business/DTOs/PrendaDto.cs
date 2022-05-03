using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaLaura.Business.DTOs
{
    public class PrendaDto
    {

        public int PrendaId { get; set; }

        [Required(ErrorMessage = "El nombre de la prenda es requerido")]
        [StringLength(30, ErrorMessage = "Los nombres deben contener entre 3 y 30 caracteres", MinimumLength = 3)]
        [DisplayName("Nombre")]
        public string? NombrePrenda { get; set; }
        public bool? Estado { get; set; }

        [Required(ErrorMessage = "El tipo de prenda es requerido")]
        [DisplayName("Tipo de prenda")]
        public int? TipoPrendaId { get; set; }

        [Required(ErrorMessage = "El color de la prenda es requerido")]
        [DisplayName("Color de la prenda")]
        public int? ColorId { get; set; }
    }
}
