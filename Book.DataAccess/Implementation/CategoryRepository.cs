using Book.DataAccess.Data;
using Book.entities.Models;
using Book_Store.Repositories;

namespace Book.DataAccess.Implementation
{
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        private readonly BookDbContext _dbContext;
        public CategoryRepository(BookDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }

        public void Update(Category category)
        {
            var catindb = _dbContext.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (catindb != null)
            {
                catindb.Name= category.Name;
                catindb.Description= category.Description;
                catindb.CreatedTime = DateTime.Now;
            }
        }
    }
}
