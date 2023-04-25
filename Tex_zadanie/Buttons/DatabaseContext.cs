using Microsoft.EntityFrameworkCore;

namespace Tex_zadanie.Buttons
{
    internal class DatabaseContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ProductCards.db");
        }
    }
}