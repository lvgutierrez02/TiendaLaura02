using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaura.Business.Abstract;
using TiendaLaura.Business.DTOs;
using TiendaLaura.DAL.DAL;
using TiendaLaura.Models.TiendaLaura.Entities;

namespace TiendaLaura.Business.Business
{
    public class PrendaBusiness : IPrendaBusiness
    {
        private readonly AppDbContext _context;
        public PrendaBusiness(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PrendaDetalleDto>> GetPrendas()
        {

            return await _context.Prendas.Select(p => new PrendaDetalleDto
            {
                PrendaId = p.PrendaId,
                Color = p.Color.NombreColor,
                NombrePrenda = p.NombrePrenda,
                TipoPrenda = p.TipoPrenda.TipoPrendaNombre,
                Estado = p.Estado
            }).ToListAsync();

        }

        public async Task<PrendaDto> GetPrendasPorId(int? id) {

            var prendaDto = await _context.Prendas.Select(p => new PrendaDto
            {
                PrendaId = p.PrendaId,
                ColorId = p.ColorId,
                NombrePrenda = p.NombrePrenda,
                TipoPrendaId = p.TipoPrendaId,
                Estado = p.Estado

            }).FirstOrDefaultAsync(p => p.PrendaId == id);

            return prendaDto;

        }


        public void GuardarPrenda(PrendaDto prendaDto) {

            if (prendaDto == null)
            {
                throw new ArgumentNullException(nameof(prendaDto));

            }
            Prenda prenda = new()
            {
                PrendaId = prendaDto.PrendaId,
                ColorId = prendaDto.ColorId,
                NombrePrenda = prendaDto.NombrePrenda,
                TipoPrendaId = prendaDto.TipoPrendaId,
                Estado = true

            };

            _context.Prendas.Add(prenda);

        }


        public void EditarPrenda(PrendaDto prendaDto)
        {

            if (prendaDto==null)
            {
                throw new ArgumentNullException(nameof(prendaDto)); 
            }
            Prenda prenda = new()
            {
                PrendaId = prendaDto.PrendaId,
                ColorId = prendaDto.ColorId,
                NombrePrenda = prendaDto.NombrePrenda,
                TipoPrendaId = prendaDto.TipoPrendaId,
                Estado = prendaDto.Estado

            };

            _context.Prendas.Update(prenda);

        }

        public async Task<bool> GuardarCambios() {

            return await _context.SaveChangesAsync()>0; // SaveChangesAsync devuelce un valor mayor a 0 cuando se realizó la operación satisfactoriamente, devuelve un true si se realizó la operación

        }

        



    }
}
