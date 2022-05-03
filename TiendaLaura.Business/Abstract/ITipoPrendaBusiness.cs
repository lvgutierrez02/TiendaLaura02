using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaura.Business.DTOs;

namespace TiendaLaura.Business.Abstract
{
    public interface ITipoPrendaBusiness
    {
        Task<IEnumerable<TipoPrendaDto>> GetTiposPrenda();
    }
}
