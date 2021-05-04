using Microsoft.EntityFrameworkCore;

namespace Zjazd4
{
    public class TPHContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "...");
            base.OnConfiguring(optionsBuilder);
        }
        
        public DbSet<Osoba> Osoby { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Klient>();
            modelBuilder.Entity<Pracownik>();
            modelBuilder.Entity<Osoba>().ToTable("Osoba");
        }
    }
}