
namespace Teleimot.Data
{
    using System.Data.Entity;
    using Models;
    using System.Data.Entity.Infrastructure;

    public interface ITeleimotDbContext
    {
        IDbSet<User> Users { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();

        void Dispose();
    }

}
