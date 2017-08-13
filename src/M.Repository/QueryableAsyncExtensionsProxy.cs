using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M.Repository
{
    /// <summary>
    /// A proxy for concrete implementation of asynchronous query operations.
    /// </summary>
    public static class QueryableAsyncExtensionsProxy
    {
        private static IQueryableAsyncExtensionsProxy extensions;

        /// <summary>
        /// Initializes the proxy with concrete IQueryableAsyncExtensionsProxy implementation.
        /// </summary>
        /// <param name="extensions">Concrete IQueryableAsyncExtensionsProxy implementation</param>
        public static void Initialize(IQueryableAsyncExtensionsProxy extensions)
        {
            QueryableAsyncExtensionsProxy.extensions = extensions;
        }

        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if every element of the source sequence passes the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AllAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.AllAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if every element of the source sequence passes the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AllAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.AllAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to check for being empty.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the source sequence contains any elements; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.AnyAsync(source);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to check for being empty.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the source sequence contains any elements; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.AnyAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if any elements in the source sequence pass the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.AnyAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> whose elements to test for a condition.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if any elements in the source sequence pass the test in the specified predicate; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> AnyAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.AnyAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int32" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<int> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int32" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<int> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int32" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<int?> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int32" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int64" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<long> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int64" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<long> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int64" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<long?> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int64" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Single" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float> AverageAsync(this IQueryable<float> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Single" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float> AverageAsync(this IQueryable<float> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Single" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float?> AverageAsync(this IQueryable<float?> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Single" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float?> AverageAsync(this IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Double" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<double> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Double" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync(this IQueryable<double> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Double" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<double?> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Double" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync(this IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal> AverageAsync(this IQueryable<decimal> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal> AverageAsync(this IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }


        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the average of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal?> AverageAsync(this IQueryable<decimal?> source)
        {
            return extensions.AverageAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the average of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal?> AverageAsync(this IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<float?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<double?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return extensions.AverageAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source"> A sequence of values to calculate the average of. </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the average of the sequence of values.
        /// </returns>
        public static Task<decimal?> AverageAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return extensions.AverageAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="item"> The object to locate in the sequence. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the input sequence contains the specified value; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> ContainsAsync<TSource>(this IQueryable<TSource> source, TSource item)
        {
            return extensions.ContainsAsync(source, item);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="item"> The object to locate in the sequence. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>true</c> if the input sequence contains the specified value; otherwise, <c>false</c>.
        /// </returns>
        public static Task<bool> ContainsAsync<TSource>(this IQueryable<TSource> source, TSource item, CancellationToken cancellationToken)
        {
            return extensions.ContainsAsync(source, item, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.CountAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.CountAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.CountAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        public static Task<int> CountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.CountAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" />.
        /// </returns>
        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.FirstAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" />.
        /// </returns>
        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.FirstAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" /> that passes the test in
        /// <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.FirstAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the first element in <paramref name="source" /> that passes the test in
        /// <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> FirstAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.FirstAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if
        /// <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.
        /// </returns>
        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.FirstOrDefaultAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if
        /// <paramref name="source" /> is empty; otherwise, the first element in <paramref name="source" />.
        /// </returns>
        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.FirstOrDefaultAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition
        /// or a default value if no such element is found.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if <paramref name="source" />
        /// is empty or if no element passes the test specified by <paramref name="predicate" /> ; otherwise, the first
        /// element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.FirstOrDefaultAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition
        /// or a default value if no such element is found.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the first element of.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains <c>default</c> ( <typeparamref name="TSource" /> ) if <paramref name="source" />
        /// is empty or if no element passes the test specified by <paramref name="predicate" /> ; otherwise, the first
        /// element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> FirstOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.FirstOrDefaultAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.LongCountAsync(source);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the input sequence.
        /// </returns>
        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.LongCountAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the number of elements in a sequence
        /// that satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.LongCountAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the number of elements in a sequence
        /// that satisfy a condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to be counted.
        /// </param>
        /// <param name="predicate"> A function to test each element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the number of elements in the sequence that satisfy the condition in the predicate function.
        /// </returns>
        public static Task<long> LongCountAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.LongCountAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        public static Task<TSource> MaxAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.MaxAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        public static Task<TSource> MaxAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.MaxAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the value returned by the function represented by <paramref name="selector" /> .
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        public static Task<TResult> MaxAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return extensions.MaxAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the value returned by the function represented by <paramref name="selector" /> .
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the maximum of.
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the maximum value in the sequence.
        /// </returns>
        public static Task<TResult> MaxAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return extensions.MaxAsync(source, selector, cancellationToken);
        }


        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        public static Task<TSource> MinAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.MinAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        public static Task<TSource> MinAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.MinAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the value returned by the function represented by <paramref name="selector" /> .
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        public static Task<TResult> MinAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector)
        {
            return extensions.MinAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the value returned by the function represented by <paramref name="selector" /> .
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> that contains the elements to determine the minimum of.
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the minimum value in the sequence.
        /// </returns>
        public static Task<TResult> MinAsync<TSource, TResult>(this IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken)
        {
            return extensions.MinAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception
        /// if there is not exactly one element in the sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence.
        /// </returns>
        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.SingleAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception
        /// if there is not exactly one element in the sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence.
        /// </returns>
        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.SingleAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the the single element of.
        /// </param>
        /// <param name="predicate"> A function to test an element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.SingleAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition,
        /// and throws an exception if more than one such element exists.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="predicate"> A function to test an element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />.
        /// </returns>
        public static Task<TSource> SingleAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.SingleAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty;
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence, or <c>default</c> (<typeparamref name="TSource" />)
        /// if the sequence contains no elements.
        /// </returns>
        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.SingleOrDefaultAsync(source);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty;
        /// this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence, or <c>default</c> (<typeparamref name="TSource" />)
        /// if the sequence contains no elements.
        /// </returns>
        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.SingleOrDefaultAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if more than one element
        /// satisfies the condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="predicate"> A function to test an element for a condition. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />, or <c>default</c> ( <typeparamref name="TSource" /> ) if no such element is found.
        /// </returns>
        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate)
        {
            return extensions.SingleOrDefaultAsync(source, predicate);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or
        /// a default value if no such element exists; this method throws an exception if more than one element
        /// satisfies the condition.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to return the single element of.
        /// </param>
        /// <param name="predicate"> A function to test an element for a condition. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the single element of the input sequence that satisfies the condition in
        /// <paramref name="predicate" />, or <c>default</c> ( <typeparamref name="TSource" /> ) if no such element is found.
        /// </returns>
        public static Task<TSource> SingleOrDefaultAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken)
        {
            return extensions.SingleOrDefaultAsync(source, predicate, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains  the sum of the values in the sequence.
        /// </returns>
        public static Task<int> SumAsync(this IQueryable<int> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<int> SumAsync(this IQueryable<int> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int32" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<int?> SumAsync(this IQueryable<int?> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int32" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int32" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<int?> SumAsync(this IQueryable<int?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

                /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<long> SumAsync(this IQueryable<long> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<long> SumAsync(this IQueryable<long> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }
        
        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int64" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<long?> SumAsync(this IQueryable<long?> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Int64" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Int64" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<long?> SumAsync(this IQueryable<long?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Single" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<float> SumAsync(this IQueryable<float> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Single" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<float> SumAsync(this IQueryable<float> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Single" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<float?> SumAsync(this IQueryable<float?> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Single" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Single" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<float?> SumAsync(this IQueryable<float?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Double" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<double> SumAsync(this IQueryable<double> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Double" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<double> SumAsync(this IQueryable<double> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Double" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<double?> SumAsync(this IQueryable<double?> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Double" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Double" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<double?> SumAsync(this IQueryable<double?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Decimal" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<decimal> SumAsync(this IQueryable<decimal> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of <see cref="T:System.Decimal" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<decimal> SumAsync(this IQueryable<decimal> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the sum of.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<decimal?> SumAsync(this IQueryable<decimal?> source)
        {
            return extensions.SumAsync(source);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of nullable <see cref="T:System.Decimal" /> values.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// A sequence of nullable <see cref="T:System.Decimal" /> values to calculate the sum of.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the values in the sequence.
        /// </returns>
        public static Task<decimal?> SumAsync(this IQueryable<decimal?> source, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<int> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<int> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<int?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int32" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<int?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<long> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<long> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<long?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Int64" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<long?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<float> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<float> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<float?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Single" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<float?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<double> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<double> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<double?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Double" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<double?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<decimal> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<decimal> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<decimal?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector)
        {
            return extensions.SumAsync(source, selector);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of nullable <see cref="T:System.Decimal" /> values that is obtained
        /// by invoking a projection function on each element of the input sequence.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" /> .
        /// </typeparam>
        /// <param name="source">
        /// A sequence of values of type <typeparamref name="TSource" /> .
        /// </param>
        /// <param name="selector"> A projection function to apply to each element. </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the sum of the projected values.
        /// </returns>
        public static Task<decimal?> SumAsync<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken)
        {
            return extensions.SumAsync(source, selector, cancellationToken);
        }

        /// <summary>
        /// Creates an array from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to create an array from.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains an array that contains elements from the input sequence.
        /// </returns>
        public static Task<TSource[]> ToArrayAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.ToArrayAsync(source);
        }

        /// <summary>
        /// Creates an array from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to create an array from.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains an array that contains elements from the input sequence.
        /// </returns>
        public static Task<TSource[]> ToArrayAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.ToArrayAsync(source, cancellationToken);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        public static Task<List<object>> ToListAsync(this IQueryable source)
        {
            return extensions.ToListAsync(source);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        public static Task<List<object>> ToListAsync(this IQueryable source, CancellationToken cancellationToken)
        {
            return extensions.ToListAsync(source, cancellationToken);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to create a <see cref="T:System.Collections.Generic.List`1" /> from.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        public static Task<List<TSource>> ToListAsync<TSource>(this IQueryable<TSource> source)
        {
            return extensions.ToListAsync(source);
        }

        /// <summary>
        /// Creates a <see cref="T:System.Collections.Generic.List`1" /> from an <see cref="T:System.Linq.IQueryable`1" /> by enumerating it asynchronously.
        /// </summary>
        /// <remarks>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </remarks>
        /// <typeparam name="TSource">
        /// The type of the elements of <paramref name="source" />.
        /// </typeparam>
        /// <param name="source">
        /// An <see cref="T:System.Linq.IQueryable`1" /> to create a list from.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains a <see cref="T:System.Collections.Generic.List`1" /> that contains elements from the input sequence.
        /// </returns>
        public static Task<List<TSource>> ToListAsync<TSource>(this IQueryable<TSource> source, CancellationToken cancellationToken)
        {
            return extensions.ToListAsync(source, cancellationToken);
        }
    }
}
