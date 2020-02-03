using System.Collections.Generic;

namespace CarInsurance.Service.Interfaces
{
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(List<string> relations);
    }
}
