using Microsoft.EntityFrameworkCore;

namespace Tex_zadanie.Buttons
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        
    }
}