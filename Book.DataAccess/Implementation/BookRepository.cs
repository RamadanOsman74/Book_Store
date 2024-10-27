using Book.DataAccess.Data;
using Book.Entities.Models;
using Book_Store.Repositories;



namespace Book.DataAccess.Implementation
{
    public class BookRepository : GenericRepository<Books>,IBookRepository
    {
        private readonly BookDbContext _dbContext;
        public BookRepository(BookDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }

        public void Update(Books Book)
        {
            var bookindb = _dbContext.Books.FirstOrDefault(c => c.Id == Book.Id);
            if (bookindb != null)
            {
                bookindb.Name= Book.Name;
                bookindb.Description= Book.Description;
                bookindb.Price = Book.Price;
                bookindb.Image= Book.Image;
                bookindb.CategoryId = Book.CategoryId;
            }
        }

   
    }
}
