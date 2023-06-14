using Microsoft.EntityFrameworkCore;
using To_do.Models;

namespace To_do.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Afazer> Afazeres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Afazer>().HasData
            (
                new Afazer()
                {
                    Id = 1,
                    Titulo = "Teste",
                    Desc = "Apenas um Teste",
                    Data = DateTime.Now,
                    Status = true
                }
            );
        }
    }
}