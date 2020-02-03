using CarInsurance.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarInsurance.Repository.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly CarInsuranceContext dbContext;
        private readonly DbSet<TEntity> entitySet;

        public Repository(CarInsuranceContext context)
        {
            dbContext = context;
            entitySet = dbContext.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            entitySet.Add(entity);
            dbContext.SaveChanges();
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return entitySet.AsEnumerable();
        }

        public virtual IEnumerable<TEntity> Get(List<string> relations)
        {
            switch (relations.Count())
            {
                case 1:
                    return entitySet.Include(relations[0]).AsEnumerable();
                case 2:
                    return entitySet.Include(relations[0]).Include(relations[1]).AsEnumerable();
                default:
                    return entitySet.AsEnumerable();
            }
        }
    }
}
