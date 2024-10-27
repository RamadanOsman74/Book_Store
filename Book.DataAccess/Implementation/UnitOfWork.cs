using Book.DataAccess.Data;
using Book.Entities.Repositories;
using Book_Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookDbContext _dbContext;
        public ICategoryRepository category { get; private set; }
        public IBookRepository book { get; private set; }
        public IShoppingCartRepository shoppingCart { get; private set; }
        public IOrderDetailRepository orderDetail { get; private set; }
        public IOrderHeaderRepository orderHeader { get; private set; }

        public IApplicationUserRepository applicationUser { get; private set; }
	

		public UnitOfWork(BookDbContext dbcontext ) 
        {
            _dbContext = dbcontext;
            category = new CategoryRepository(dbcontext);
            book = new BookRepository(dbcontext);
            shoppingCart = new ShoppingCartRepository(dbcontext);
            orderDetail =new OrderDetailRepository(dbcontext);
            orderHeader = new OrderHeaderRepository(dbcontext);
            applicationUser = new ApplicationUserRepository(dbcontext);
        }
       

        public int complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
