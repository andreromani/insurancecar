using CarInsurance.Repository;
using CarInsurance.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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

        //public int Count()
        //{
        //    return _repository.Count();
        //}

        //public void Delete(params object[] keys)
        //{
        //    TEntity entity = GetById(keys);

        //    if(entity != null)
        //    {
        //        _repository.Delete(entity);
        //    }
        //}

        //public void Delete(TEntity entity)
        //{
        //    _repository.Delete(entity);
        //}

        //public bool ExistsById(params object[] keys)
        //{
        //    return _repository.ExistsById(keys);
        //}

        //public TEntity First()
        //{
        //    return _repository.First();
        //}

        public IEnumerable<TEntity> Get()
        {
            return _repository.Get();
        }

        public IEnumerable<TEntity> Get(List<string> relations)
        {
            return _repository.Get(relations);
        }

        //public TEntity GetById(params object[] keys)
        //{
        //    return _repository.GetById(keys);
        //}

        //public TEntity Last()
        //{
        //    return _repository.Last();
        //}

        //public void Update(TEntity entity)
        //{
        //    _repository.Update(entity);
        //}
    }
}
