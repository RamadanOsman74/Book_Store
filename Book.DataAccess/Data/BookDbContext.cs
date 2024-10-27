using Book.entities.Models;
using Book.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Book.DataAccess.Data
{
    public class BookDbContext: IdentityDbContext<IdentityUser>
    {
        public BookDbContext(DbContextOptions<BookDbContext> options ): base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<ShoppingCart> shoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }



	}
}
