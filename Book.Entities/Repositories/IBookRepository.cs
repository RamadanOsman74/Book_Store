using Book.entities.Models;
using Book.Entities.Models;

namespace Book_Store.Repositories
{
    public interface IBookRepository : IGenericRepository<Book.Entities.Models.Books>
    {
        void Update(Book.Entities.Models.Books book);
    }
}
