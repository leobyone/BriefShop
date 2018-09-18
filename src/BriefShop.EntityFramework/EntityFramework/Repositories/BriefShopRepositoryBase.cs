using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace BriefShop.EntityFramework.Repositories
{
    public abstract class BriefShopRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<BriefShopDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected BriefShopRepositoryBase(IDbContextProvider<BriefShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class BriefShopRepositoryBase<TEntity> : BriefShopRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected BriefShopRepositoryBase(IDbContextProvider<BriefShopDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
