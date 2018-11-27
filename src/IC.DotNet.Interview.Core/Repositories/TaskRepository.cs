using System.Collections.Generic;
using IC.DotNet.Interview.Core.Database;
using IC.DotNet.Interview.Core.Models;

namespace IC.DotNet.Interview.Core.Repositories
{
    public class TaskRepository : GenericRepository<Task>, ITaskRepository
    {
        public TaskRepository(IDbContext dbContext) : base(dbContext)
        {
        }
    }
}
