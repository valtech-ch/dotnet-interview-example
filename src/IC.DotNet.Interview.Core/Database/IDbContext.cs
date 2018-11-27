using IC.DotNet.Interview.Core.Repositories;
using System.Collections.Generic;

namespace IC.DotNet.Interview.Core.Database
{
    public interface IDbContext
    {
        ICollection<T> GetDataset<T>();
        bool Save();
    }
}
