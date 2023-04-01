using Microsoft.EntityFrameworkCore;
using PraticandoASPCORE.Models;

namespace PraticandoASPCORE.Contexto
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options): base(options) {
            
        }

        public DbSet<Car> Cars { get; set; }    
        public DbSet<User> Users { get; set; }    
    }
}
