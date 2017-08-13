using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace M.Repository
{
    /// <summary>
    /// A base class for query implementations.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities that will be queried.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public abstract class QueryBase<TEntity, TResult> : IQueryBase<TEntity, TResult>
        where TEntity : IEntity
    {
        private static IEnumerable<Expression<Func<TEntity, object>>> empty = new Expression<Func<TEntity, object>>[] { };

        /// <summary>
        /// A list of expressions specifying related entites to be returned along with the query result.
        /// </summary>
        protected Lazy<List<Expression<Func<TEntity, object>>>> includes =
            new Lazy<List<Expression<Func<TEntity, object>>>>(() => new List<Expression<Func<TEntity, object>>>());

        /// <summary>
        /// Gets a list of related entities to be returned along with the query result.
        /// </summary>
        public IEnumerable<Expression<Func<TEntity, object>>> Includes
        {
            get { return includes.IsValueCreated ? includes.Value : empty; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the result of the query will be used for entities modificatoins.
        /// </summary>
        public bool ReadOnly
        {
            get; set;
        }
    }
}

