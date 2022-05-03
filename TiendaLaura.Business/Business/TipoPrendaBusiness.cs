using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaura.Business.Abstract;
using TiendaLaura.Business.DTOs;
using TiendaLaura.DAL.DAL;

namespace TiendaLaura.Business.Business
{
    public class TipoPrendaBusiness: ITipoPrendaBusiness
    {
        private readonly AppDbContext _context;
        public TipoPrendaBusiness(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TipoPrendaDto>> GetTiposPrenda()
        {

            return await _context.TiposPrenda.Select(t=> new TipoPrendaDto
            {
                TipoPrendaId = t.TipoPrendaId,  
                TipoPrendaNombre = t.TipoPrendaNombre
                
            }).ToListAsync();

        }
    }
}
