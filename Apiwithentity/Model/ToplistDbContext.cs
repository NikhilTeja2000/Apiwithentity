using Microsoft.EntityFrameworkCore;

namespace Apiwithentity.Model
{
    public class ToplistDbContext:DbContext
    {
        public ToplistDbContext(DbContextOptions<ToplistDbContext> options):base(options)
        {

        }
        public DbSet<Toplist> Toplists { get; set; }

        public DbSet<Books> Books { get; set; }

        public DbSet<Category> Category { get; set; }
        public DbSet<Customerdetails> Customerdetails { get; set; }
        public DbSet<Userdetails> Userdetails { get; set; }

        public DbSet<Wishlist> Wishlists { get; set; }

        public DbSet<Cart> Cart { get; set; }




    }
}
