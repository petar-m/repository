using System;
using System.Linq;
using System.Linq.Expressions;

namespace M.Repository
{
    /// <summary>
    /// A base class for synchonous queries.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities that will be queried.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public abstract class Query<TEntity, TResult> : QueryBase<TEntity, TResult>, IQuery<TEntity, TResult>
        where TEntity : IEntity
    {
        /// <summary>
        /// Executes the query synchonously.
        /// </summary>
        /// <param name="items">The IQueryable source to execute the query against.</param>
        /// <returns>The result of the query execution.</returns>
        public abstract TResult ExecuteAgainst(IQueryable<TEntity> items);

        /// <summary>
        /// Specifies a related entities to be returned along with the query result.
        /// </summary>
        /// <param name="selector">An expression describing the related entities.</param>
        /// <returns>An instance of the modified query.</returns>
        public IQuery<TEntity, TResult> Include(Expression<Func<TEntity, object>> selector)
        {
            includes.Value.Add(selector);
            return this;
        }
    }
}

