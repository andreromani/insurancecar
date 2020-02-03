using CarInsurance.Repository;
using CarInsurance.Service.Interfaces;
using System.Collections.Generic;

namespace CarInsurance.Service
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public Service(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Add(TEntity entity)
        {
            _repository.Add(entity);
        }

        public IEnumerable<TEntity> Get()
        {
            return _repository.Get();
        }

        public IEnumerable<TEntity> Get(List<string> relations)
        {
            return _repository.Get(relations);
        }

    }
}
