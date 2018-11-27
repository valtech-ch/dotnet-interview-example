using IC.DotNet.Interview.Core.Database;
using IC.DotNet.Interview.Core.Models;
using System.Collections.Generic;

namespace IC.DotNet.Interview.Core.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
