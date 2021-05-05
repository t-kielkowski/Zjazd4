using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Zjazd4
{
    public class TPTContext : DbContext
    {
        static IConfigurationBuilder  builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
        static IConfiguration  configuration = builder.Build();
            
        string connectionString = configuration.GetConnectionString("myDb1");
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString);
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