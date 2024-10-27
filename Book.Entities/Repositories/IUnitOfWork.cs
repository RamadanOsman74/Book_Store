using Book_Store.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Entities.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository category { get; }
        IBookRepository book { get; }
        IShoppingCartRepository shoppingCart { get; }
        IOrderDetailRepository orderDetail {  get; }
        IOrderHeaderRepository orderHeader { get; } 
        IApplicationUserRepository applicationUser { get; }
        int complete();

    }
}
