using Book.entities.Models;

namespace Book_Store.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        void Update(Category category);
    }
}
