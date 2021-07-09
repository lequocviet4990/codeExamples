using AwesomeBlogDTO;
using Microsoft.EntityFrameworkCore;

namespace AwesomeBlogBackEnd.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<EcommerceShop> EcommerceShops { get; set; }

        public DbSet<EcommerceShopLink> EcommerceShopLinks { get; set; }
    }
}