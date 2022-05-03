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
    public class ColorBusiness : IColorBusiness
    {
        private readonly AppDbContext _context;
        public ColorBusiness(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ColorDto>> GetColores()
        {
            return await _context.Colores.Select(c => new ColorDto
            {
                ColorId= c.ColorId,
                Color=c.NombreColor

                
            }).ToListAsync();

        }
    }
}
