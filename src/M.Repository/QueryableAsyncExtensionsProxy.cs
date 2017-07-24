using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M.Repository
{
    public static class QueryableAsyncExtensionsProxy
    {
        private static IQueryableAsyncExtensionsProxy extensions;

        public static void Initialize(IQueryableAsyncExtensionsProxy extensions)
        {
            QueryableAsyncExtensionsProxy.extensions = extensions;
        }

        public static Task<bool> AllAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.AllAsync(source, predicate);
        }

        public static Task<bool> AllAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.AllAsync(source, predicate, cancellationToken);
        }

        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.AnyAsync(source);
        }

        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.AnyAsync(source, cancellationToken);
        }

        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.AnyAsync(source, predicate);
        }

        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.AnyAsync(source, predicate, cancellationToken);
        }

        public static Task<double> AverageAsync(this IQueryable<int> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double> AverageAsync(this IQueryable<int> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IQueryable<int?> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double?> AverageAsync(this IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double> AverageAsync(this IQueryable<long> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double> AverageAsync(this IQueryable<long> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IQueryable<long?> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double?> AverageAsync(this IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<float> AverageAsync(this IQueryable<float> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<float> AverageAsync(this IQueryable<float> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<float?> AverageAsync(this IQueryable<float?> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<float?> AverageAsync(this IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double> AverageAsync(this IQueryable<double> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double> AverageAsync(this IQueryable<double> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double?> AverageAsync(this IQueryable<double?> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<double?> AverageAsync(this IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<decimal> AverageAsync(this IQueryable<decimal> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<decimal> AverageAsync(this IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<decimal?> AverageAsync(this IQueryable<decimal?> source)
        {
            return extensions.AverageAsync(source);
        }

        public static Task<decimal?> AverageAsync(this IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<float> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<float> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<float?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<float?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<decimal> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<decimal> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<decimal?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        public static Task<decimal?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        public static Task<bool> ContainsAsync<TSource>(this IQueryable<TSource> source, TSource item)
        {
            return extensions.ContainsAsync(source, item);
        }

        public static Task<bool> ContainsAsync<TSource>(this IQueryable<TSource> source, TSource item, CancellationToken cancellationToken)
        {
            return extensions.ContainsAsync(source, item, cancellationToken);
        }

        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.CountAsync(source);
        }

        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.CountAsync(source, cancellationToken);
        }

        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.CountAsync(source, predicate);
        }

        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.CountAsync(source, predicate, cancellationToken);
        }

        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.FirstAsync(source);
        }

        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.FirstAsync(source, cancellationToken);
        }

        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.FirstAsync(source, predicate);
        }

        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.FirstAsync(source, predicate, cancellationToken);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.FirstOrDefaultAsync(source);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.FirstOrDefaultAsync(source, cancellationToken);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.FirstOrDefaultAsync(source, predicate);
        }

        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.FirstOrDefaultAsync(source, predicate, cancellationToken);
        }

        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.LongCountAsync(source);
        }

        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.LongCountAsync(source, cancellationToken);
        }

        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.LongCountAsync(source, predicate);
        }

        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.LongCountAsync(source, predicate, cancellationToken);
        }

        public static Task<TSource> MaxAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.MaxAsync(source);
        }

        public static Task<TSource> MaxAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.MaxAsync(source, cancellationToken);
        }

        public static Task<TResult> MaxAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return extensions.MaxAsync(source, selector);
        }

        public static Task<TResult> MaxAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return extensions.MaxAsync(source, selector, cancellationToken);
        }

        public static Task<TSource> MinAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.MinAsync(source);
        }

        public static Task<TSource> MinAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.MinAsync(source, cancellationToken);
        }

        public static Task<TResult> MinAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return extensions.MinAsync(source, selector);
        }

        public static Task<TResult> MinAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return extensions.MinAsync(source, selector, cancellationToken);
        }

        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.SingleAsync(source);
        }

        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.SingleAsync(source, cancellationToken);
        }

        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.SingleAsync(source, predicate);
        }

        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.SingleAsync(source, predicate, cancellationToken);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.SingleOrDefaultAsync(source);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.SingleOrDefaultAsync(source, cancellationToken);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.SingleOrDefaultAsync(source, predicate);
        }

        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.SingleOrDefaultAsync(source, predicate, cancellationToken);
        }

        public static Task<int> SumAsync(this IQueryable<int> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<int> SumAsync(this IQueryable<int> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<int?> SumAsync(this IQueryable<int?> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<int?> SumAsync(this IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<long> SumAsync(this IQueryable<long> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<long> SumAsync(this IQueryable<long> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<long?> SumAsync(this IQueryable<long?> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<long?> SumAsync(this IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<float> SumAsync(this IQueryable<float> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<float> SumAsync(this IQueryable<float> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<float?> SumAsync(this IQueryable<float?> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<float?> SumAsync(this IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<double> SumAsync(this IQueryable<double> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<double> SumAsync(this IQueryable<double> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<double?> SumAsync(this IQueryable<double?> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<double?> SumAsync(this IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<decimal> SumAsync(this IQueryable<decimal> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<decimal> SumAsync(this IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<decimal?> SumAsync(this IQueryable<decimal?> source)
        {
            return extensions.SumAsync(source);
        }

        public static Task<decimal?> SumAsync(this IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        public static Task<int> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<int> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<int?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<int?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<long> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<long> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<long?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<long?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<float> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<float> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<float?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<float?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<double> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<double> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<double?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<double?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<decimal> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<decimal> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<decimal?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        public static Task<decimal?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        public static Task<TSource[]> ToArrayAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.ToArrayAsync(source);
        }

        public static Task<TSource[]> ToArrayAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.ToArrayAsync(source, cancellationToken);
        }

        public static Task<List<object>> ToListAsync(this IQueryable source)
        {
            return extensions.ToListAsync(source);
        }

        public static Task<List<object>> ToListAsync(this IQueryable source, CancellationToken cancellationToken)
        {
            return extensions.ToListAsync(source, cancellationToken);
        }

        public static Task<List<TSource>> ToListAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.ToListAsync(source);
        }

        public static Task<List<TSource>> ToListAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.ToListAsync(source, cancellationToken);
        }
    }
}
