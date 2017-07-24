using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace M.Repository
{
    public abstract class QueryBase<TEntity, TResult> : IQueryBase<TEntity, TResult>
        where TEntity : IEntity
    {
        private static IEnumerable<Expression<Func<TEntity, object>>> empty = new Expression<Func<TEntity, object>>[] { };

        private Lazy<List<Expression<Func<TEntity, object>>>> includes =
            new Lazy<List<Expression<Func<TEntity, object>>>>(() => new List<Expression<Func<TEntity, object>>>());

        public IEnumerable<Expression<Func<TEntity, object>>> Includes
        {
            get { return includes.IsValueCreated ? includes.Value : empty; }
        }

        public bool ReadOnly
        {
            get; set;
        }

        public IQueryBase<TEntity, TResult> Include(Expression<Func<TEntity, object>> selector)
        {
            includes.Value.Add(selector);
            return this;
        }
    }

    public abstract class Query<TEntity, TResult> : QueryBase<TEntity, TResult>, IQuery<TEntity, TResult>
        where TEntity : IEntity
    {
        public abstract TResult ExecuteAgainst(IQueryable<TEntity> items);
    }

    public abstract class QueryAsync<TEntity, TResult> : QueryBase<TEntity, TResult>, IQueryAsync<TEntity, TResult>
        where TEntity : IEntity
    {
        public abstract Task<TResult> ExecuteAgainstAsync(IQueryable<TEntity> items);
    }
}

