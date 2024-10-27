using Book.entities.Models;
using Book.Entities.Models;

namespace Book_Store.Repositories
{
    public interface IOrderDetailRepository : IGenericRepository<OrderDetail>
    {
        void Update(OrderDetail orderDetail);
    }
}
