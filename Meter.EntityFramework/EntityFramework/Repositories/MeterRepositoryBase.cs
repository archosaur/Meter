using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Meter.EntityFramework.Repositories
{
    public abstract class MeterRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MeterDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MeterRepositoryBase(IDbContextProvider<MeterDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MeterRepositoryBase<TEntity> : MeterRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MeterRepositoryBase(IDbContextProvider<MeterDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
