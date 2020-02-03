using System.Collections.Generic;

namespace CarInsurance.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(List<string> relations);
    }
}
