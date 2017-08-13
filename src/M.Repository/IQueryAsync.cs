using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace M.Repository
{
    /// <summary>
    /// Represens an asyncronous query.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities that will be queried.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public interface IQueryAsync<TEntity, TResult> : IQueryBase<TEntity, TResult> where TEntity : IEntity
    {
        /// <summary>
        /// Executes the query asynchonously.
        /// </summary>
        /// <param name="items">The IQueryable source to execute the query against.</param>
        /// <returns>A task representing the result of the query execution.</returns>
        Task<TResult> ExecuteAgainstAsync(IQueryable<TEntity> items);

        /// <summary>
        /// Specifies a related entities to be returned along with the query result.
        /// </summary>
        /// <param name="selector">An expression describing the related entities.</param>
        /// <returns>An instance of the modified query.</returns>
        IQueryAsync<TEntity, TResult> Include(Expression<Func<TEntity, object>> selector);
    }
}