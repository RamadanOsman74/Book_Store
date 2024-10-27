using Book.DataAccess.Data;
using Book.entities.Models;
using Book.Entities.Models;
using Book_Store.Repositories;
using Book.Entities.Repositories;

namespace Book.DataAccess.Implementation
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>,IShoppingCartRepository
    {
        private readonly BookDbContext _dbContext;
        public ShoppingCartRepository(BookDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }

        public int DecreaseCount(ShoppingCart cart, int count)
        {
            cart.Count -= count;
            return cart.Count;
        }

        public int IncreaseCount(ShoppingCart cart, int count)
        {
            cart.Count += count;
            return cart.Count;
        }
    }
}
