using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaLaura.Models.TiendaLaura.Entities;

namespace TiendaLaura.DAL.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options) {
                

        
        }

       public DbSet<Prenda> Prendas { get; set; }
       public DbSet<TipoPrenda> TiposPrenda { get; set; }
       public DbSet<Color> Colores { get; set; }

    }
}
