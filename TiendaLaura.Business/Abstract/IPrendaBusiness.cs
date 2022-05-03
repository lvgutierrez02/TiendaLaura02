using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaura.Business.DTOs;

namespace TiendaLaura.Business.Abstract
{
    public interface IPrendaBusiness
    {
        Task<IEnumerable<PrendaDetalleDto>> GetPrendas();
        Task<PrendaDto> GetPrendasPorId(int? id);
        void GuardarPrenda(PrendaDto prendaDto);
        void EditarPrenda(PrendaDto prendaDto);
        Task<bool> GuardarCambios();

    }
}
