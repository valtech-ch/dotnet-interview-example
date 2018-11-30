using System.Collections.Generic;

namespace IC.DotNet.Interview.Core.Database
{
    public interface IDbContext
    {
        ICollection<T> GetDataset<T>();
        bool Save();
    }
}
