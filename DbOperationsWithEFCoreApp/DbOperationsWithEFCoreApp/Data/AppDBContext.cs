using DbOperationsWithEFCoreApp.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace DbOperationsWithEFCoreApp.Data
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> opt):base(opt)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Title = "INR", Description = "Indian Rupee" },
                new Currency() { Id = 2, Title = "Dollar", Description = "American Dollar" },
                new Currency() { Id = 3, Title = "Euro", Description = "European Euro" }
            );

            modelBuilder.Entity<Languages>().HasData(
                new Languages() { Id = 1, Title = "Hin", Description = "Hindi" },
                new Languages() { Id = 2, Title = "Mara", Description = "Marathi" },
                new Languages() { Id = 3, Title = "Eng", Description = "English" },
                new Languages() { Id = 4, Title = "Tamil", Description = "Tamil" }
            );
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Languages> Languages { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<BookPrice> BookPrices { get; set; }

    }
}
