namespace SourceControlSystem.Data
{
    using SourceControlSystem.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface ISourceControlSystemDbContext
    {
        IDbSet<SoftwareProject> SoftwareProjects { get; set; }

        IDbSet<Commit> Commits { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
