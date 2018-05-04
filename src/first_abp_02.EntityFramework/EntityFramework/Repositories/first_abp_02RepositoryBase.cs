using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace first_abp_02.EntityFramework.Repositories
{
    public abstract class first_abp_02RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<first_abp_02DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected first_abp_02RepositoryBase(IDbContextProvider<first_abp_02DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class first_abp_02RepositoryBase<TEntity> : first_abp_02RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected first_abp_02RepositoryBase(IDbContextProvider<first_abp_02DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
