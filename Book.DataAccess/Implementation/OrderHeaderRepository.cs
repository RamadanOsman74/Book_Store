using Book.DataAccess.Data;
using Book.entities.Models;
using Book.Entities.Models;
using Book_Store.Repositories;

namespace Book.DataAccess.Implementation
{
	public class OrderHeaderRepository : GenericRepository<OrderHeader>, IOrderHeaderRepository
	{
		private readonly BookDbContext _dbContext;

		public OrderHeaderRepository(BookDbContext dbcontext) : base(dbcontext)
		{
			_dbContext = dbcontext;
		}

		public void Update(OrderHeader orderHeader)
		{
			_dbContext.OrderHeaders.Update(orderHeader);	
		}

		public void UpdateOrderStatus(int id, string OrderStatus, string PaymentStatus)
		{
			var orderindb = _dbContext.OrderHeaders.FirstOrDefault(x => x.Id == id);
			if (orderindb != null) 
			{
				orderindb.OrderStatus = OrderStatus;
				if (PaymentStatus != null)
				{
					orderindb.PaymentStatus = PaymentStatus;
				}
			}
		}
	}


}

