using System.Collections.Generic;
using IC.DotNet.Interview.Core.Database;
using IC.DotNet.Interview.Core.Models;

namespace IC.DotNet.Interview.Core.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
