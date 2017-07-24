using System.Threading.Tasks;

namespace M.Repository
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        TEntity Find<TKey>(EntityId<TEntity, TKey> id);

        Task<TEntity> FindAsync<TKey>(EntityId<TEntity, TKey> id);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        TResult GetBy<TResult>(IQuery<TEntity, TResult> query);

        Task<TResult> GetByAsync<TResult>(IQueryAsync<TEntity, TResult> query);
    }
}
