using Microsoft.EntityFrameworkCore;

namespace Zjazd4
{
    public class TPTContext : DbContext
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Klient>().ToTable("Klienci");
            modelBuilder.Entity<Pracownik>().ToTable("Pracownicy");
        }
    }
}