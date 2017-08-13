using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace M.Repository
{
    /// <summary>
    /// Represents a common query settings.
    /// </summary>
    /// <typeparam name="TEntity">The type of the entities that will be queried.</typeparam>
    /// <typeparam name="TResult">The type of the result of the query.</typeparam>
    public interface IQueryBase<TEntity, TResult> where TEntity : IEntity
    {
        /// <summary>
        /// Gets a value indicating whether the result of the query will be used for entities modificatoins.
        /// </summary>
        bool ReadOnly { get; }

        /// <summary>
        /// Gets a list of related entities to be returned along with the query result.
        /// </summary>
        IEnumerable<Expression<Func<TEntity, object>>> Includes { get; }
    }
}
