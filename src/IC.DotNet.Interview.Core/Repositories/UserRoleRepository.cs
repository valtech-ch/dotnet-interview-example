using IC.DotNet.Interview.Core.Database;
using IC.DotNet.Interview.Core.Models;

namespace IC.DotNet.Interview.Core.Repositories
{
    public class UserRoleRepository : GenericRepository<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
