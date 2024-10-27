using Book.entities.Models;
using Book.Entities.Models;

namespace Book_Store.Repositories
{
    public interface IShoppingCartRepository : IGenericRepository<ShoppingCart>
    {
        int IncreaseCount(ShoppingCart cart, int count);
        int DecreaseCount(ShoppingCart cart, int count);

    }
}
