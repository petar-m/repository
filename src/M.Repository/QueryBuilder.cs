using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace M.Repository
{
    public static class QueryBuilder
    {
        public static IQuery<TEntity, TEntity> ById<TEntity, TKey>(EntityId<TEntity, TKey> key, bool readOnly = false) where TEntity : Entity<TKey>
        {
            var query = new QueryById<TEntity, TKey>(key) { ReadOnly = readOnly };
            return query;
        }

        public static IQueryAsync<TEntity, TEntity> ByIdAsync<TEntity, TKey>(EntityId<TEntity, TKey> key, bool readOnly = false) where TEntity : Entity<TKey>
        {
            var query = new QueryByIdAsync<TEntity, TKey>(key) { ReadOnly = readOnly };
            return query;
        }

        public static IQuery<TEntity, TEntity[]> BySpecification<TEntity>(Expression<Func<TEntity, bool>> predicate, bool readOnly = false) where TEntity : IEntity
        {
            var query = new QueryBySpecification<TEntity>(predicate) { ReadOnly = readOnly };
            return query;
        }

        public static IQueryAsync<TEntity, TEntity[]> BySpecificationAsync<TEntity>(Expression<Func<TEntity, bool>> predicate, bool readOnly = false) where TEntity : IEntity
        {
            var query = new QueryBySpecificationAsync<TEntity>(predicate) { ReadOnly = readOnly };
            return query;
        }

        public static IQuery<TEntity, TResult> ByDelegate<TEntity, TResult>(Func<IQueryable<TEntity>, TResult> @delegate, bool readOnly = false) where TEntity : IEntity
        {
            var query = new QueryByDelegate<TEntity, TResult>(@delegate) { ReadOnly = readOnly };
            return query;
        }

        public static IQueryAsync<TEntity, TResult> ByDelegateAsync<TEntity, TResult>(Func<IQueryable<TEntity>, Task<TResult>> @delegate, bool readOnly = false) where TEntity : IEntity
        {
            var query = new QueryByDelegateAsync<TEntity, TResult>(@delegate) { ReadOnly = readOnly };
            return query;
        }

        class QueryById<TEntity, TKey> : Query<TEntity, TEntity> where TEntity : Entity<TKey>
        {
            private readonly Func<IQueryable<TEntity>, TEntity> selectById;

            public QueryById(EntityId<TEntity, TKey> id)
            {
                selectById = items => items.SingleOrDefault(e => (object)e.Id == (object)id.Id);
            }

            public override TEntity ExecuteAgainst(IQueryable<TEntity> items)
            {
                var result = selectById(items);
                return result;
            }
        }

        class QueryByIdAsync<TEntity, TKey> : QueryAsync<TEntity, TEntity> where TEntity : Entity<TKey>
        {
            private readonly Func<IQueryable<TEntity>, Task<TEntity>> selectById;

            public QueryByIdAsync(EntityId<TEntity, TKey> id)
            {
                selectById = items => items.SingleOrDefaultAsync(e => (object)e.Id == (object)id.Id);
            }

            public override Task<TEntity> ExecuteAgainstAsync(IQueryable<TEntity> items)
            {
                var result = selectById(items);
                return result;
            }
        }

        class QueryBySpecification<TEntity> : Query<TEntity, TEntity[]> where TEntity : IEntity
        {
            private readonly Expression<Func<TEntity, bool>> predicate;

            public QueryBySpecification(Expression<Func<TEntity, bool>> predicate)
            {
                this.predicate = predicate;
            }

            public override TEntity[] ExecuteAgainst(IQueryable<TEntity> items)
            {
                var result = items.Where(predicate).ToArray();
                return result;
            }
        }

        class QueryBySpecificationAsync<TEntity> : QueryAsync<TEntity, TEntity[]> where TEntity : IEntity
        {
            private readonly Expression<Func<TEntity, bool>> predicate;

            public QueryBySpecificationAsync(Expression<Func<TEntity, bool>> predicate)
            {
                this.predicate = predicate;
            }

            public override Task<TEntity[]> ExecuteAgainstAsync(IQueryable<TEntity> items)
            {
                var result = items.Where(predicate).ToArrayAsync();
                return result;
            }
        }

        class QueryByDelegate<TEntity, TResult> : Query<TEntity, TResult> where TEntity : IEntity
        {
            private readonly Func<IQueryable<TEntity>, TResult> @delegate;

            public QueryByDelegate(Func<IQueryable<TEntity>, TResult> @delegate)
            {
                this.@delegate = @delegate;
            }

            public override TResult ExecuteAgainst(IQueryable<TEntity> items)
            {
                var result = @delegate(items);
                return result;
            }
        }

        class QueryByDelegateAsync<TEntity, TResult> : QueryAsync<TEntity, TResult> where TEntity : IEntity
        {
            private readonly Func<IQueryable<TEntity>, Task<TResult>> @delegate;

            public QueryByDelegateAsync(Func<IQueryable<TEntity>, Task<TResult>> @delegate)
            {
                this.@delegate = @delegate;
            }

            public override Task<TResult> ExecuteAgainstAsync(IQueryable<TEntity> items)
            {
                var result = @delegate(items);
                return result;
            }
        }
    }
}

