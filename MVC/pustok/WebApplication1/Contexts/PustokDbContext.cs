using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Contexts
{
    public class PustokDbContext : DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-41FVTKL\\SQLEXPRESS; Database = Pustok; Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
