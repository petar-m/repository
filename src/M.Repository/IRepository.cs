using System.Threading.Tasks;

namespace M.Repository
{
    /// <summary>
    /// Represents a repository for managing entities.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities managed.</typeparam>
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        /// <summary>
        /// Finds an entity by its identifier.
        /// </summary>
        /// <typeparam name="TKey">The type of the entity identifier.</typeparam>
        /// <param name="id">The concrete entity identifier.</param>
        /// <returns>The entity identified by the given id or null if not found.</returns>
        TEntity Find<TKey>(EntityId<TEntity, TKey> id);

        /// <summary>
        /// Finds an entity by its identifier asynchronously.
        /// </summary>
        /// <typeparam name="TKey">The type of the entity identifier.</typeparam>
        /// <param name="id">The concrete entity identifier.</param>
        /// <returns>The entity identified by the given id or null if not found.</returns>
        Task<TEntity> FindAsync<TKey>(EntityId<TEntity, TKey> id);

        /// <summary>
        /// Adds an entity to the repository.
        /// </summary>
        /// <param name="entity">An entity to add to the repository.</param>
        void Add(TEntity entity);

        /// <summary>
        /// Updates an entity existing in the repository.
        /// </summary>
        /// <param name="entity">An entity to update.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Deletes an entity eixisting in the repository.
        /// </summary>
        /// <param name="entity">An entity to delete from the repository.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Searches the repository for entities.
        /// </summary>
        /// <typeparam name="TResult">The type of the search result.</typeparam>
        /// <param name="query">A query instance representing the entity filter.</param>
        /// <returns>The search result.</returns>
        TResult GetBy<TResult>(IQuery<TEntity, TResult> query);

        /// <summary>
        /// Searches the repository for entities asynchronously.
        /// </summary>
        /// <typeparam name="TResult">The type of the search result.</typeparam>
        /// <param name="query">A query instance representing the entity filter.</param>
        /// <returns>A task representing the search result.</returns>
        Task<TResult> GetByAsync<TResult>(IQueryAsync<TEntity, TResult> query);
    }
}
