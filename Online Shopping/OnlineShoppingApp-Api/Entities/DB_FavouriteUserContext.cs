using Microsoft.EntityFrameworkCore;

namespace OnlineShoppingApp.Entities
{
    public class DB_FavouriteUserContext : DbContext
    {
        public DB_FavouriteUserContext()
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EITNL6U\\SQLEXPRESS;Initial Catalog=projectDbFinal;Integrated Security=True");
        }
    }
}
