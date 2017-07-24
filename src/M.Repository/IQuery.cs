using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace M.Repository
{
    public interface IQueryBase<TEntity, TResult> where TEntity : IEntity
    {
        bool ReadOnly { get; }

        IEnumerable<Expression<Func<TEntity, object>>> Includes { get; }

        IQueryBase<TEntity, TResult> Include(Expression<Func<TEntity, object>> selector);
    }

    public interface IQuery<TEntity, TResult> : IQueryBase<TEntity, TResult> where TEntity : IEntity
    {
        TResult ExecuteAgainst(IQueryable<TEntity> items);
    }

    public interface IQueryAsync<TEntity, TResult> : IQueryBase<TEntity, TResult> where TEntity : IEntity
    {
        Task<TResult> ExecuteAgainstAsync(IQueryable<TEntity> items);
    }
}
