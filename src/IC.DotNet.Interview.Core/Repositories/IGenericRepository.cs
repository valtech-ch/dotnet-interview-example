using System;
using System.Collections.Generic;

namespace IC.DotNet.Interview.Core.Repositories
{
    public interface IGenericRepository<T>
    {
        ICollection<T> Get();
        T Get(Guid id);
        bool Create(T model);
        bool Update(Guid id, T Model);
        bool Delete(Guid id, T model);
    }
}
