using Book.entities.Models;
using Book.Entities.Models;

namespace Book_Store.Repositories
{
    public interface IOrderHeaderRepository : IGenericRepository<OrderHeader>
    {
        void Update(OrderHeader orderHeader);
        void UpdateOrderStatus(int id, string OrderStatus, string PaymentStatus);
    }
}
