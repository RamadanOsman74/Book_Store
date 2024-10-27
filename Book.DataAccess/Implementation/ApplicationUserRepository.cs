using Book.DataAccess.Data;
using Book.entities.Models;
using Book.Entities.Models;
using Book_Store.Repositories;

namespace Book.DataAccess.Implementation
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>,IApplicationUserRepository
    {
        private readonly BookDbContext _dbContext;

        public ApplicationUserRepository(BookDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }
    }
}
