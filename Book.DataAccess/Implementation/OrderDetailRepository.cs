using Book.DataAccess.Data;
using Book.entities.Models;
using Book.Entities.Models;
using Book_Store.Repositories;

namespace Book.DataAccess.Implementation
{
	public class OrderDetailRepository : GenericRepository<OrderDetail>, IOrderDetailRepository
	{
		private readonly BookDbContext _dbContext;

		public OrderDetailRepository(BookDbContext dbcontext) : base(dbcontext)
		{
			_dbContext = dbcontext;
		}


		public void Update(OrderDetail orderDetail)
		{
			_dbContext.OrderDetails.Update(orderDetail);
		}
	}


}

