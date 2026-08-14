using HuellitasFelices.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HuellitasFelices.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Mascota> Mascotas { get; set; }
    }
}