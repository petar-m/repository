using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace M.Repository
{
    /// <summary>
    /// Represents an asynchronous query operations.
    /// </summary>
    public interface IQueryableAsyncExtensionsProxy
    {
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
        Task<List<object>> ToListAsync(IQueryable source);

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
        Task<List<object>> ToListAsync(IQueryable source, CancellationToken cancellationToken);

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
        Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source);

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
        Task<List<TSource>> ToListAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource[]> ToArrayAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<TSource> FirstAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<TSource> FirstOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<TSource> SingleAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<TSource> SingleOrDefaultAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item);

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
        Task<bool> ContainsAsync<TSource>(IQueryable<TSource> source, TSource item, CancellationToken cancellationToken);

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
        Task<bool> AnyAsync<TSource>(IQueryable<TSource> source);

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
        Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<bool> AnyAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<bool> AllAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<int> CountAsync<TSource>(IQueryable<TSource> source);

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
        Task<int> CountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<int> CountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);

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
        Task<long> LongCountAsync<TSource>(IQueryable<TSource> source);

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
        Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate);

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
        Task<long> LongCountAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, bool>> predicate, CancellationToken cancellationToken);


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
        Task<TSource> MinAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> MinAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);

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
        Task<TResult> MinAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken);

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
        Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source);

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
        Task<TSource> MaxAsync<TSource>(IQueryable<TSource> source, CancellationToken cancellationToken);

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
        Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector);

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
        Task<TResult> MaxAsync<TSource, TResult>(IQueryable<TSource> source, Expression<Func<TSource, TResult>> selector, CancellationToken cancellationToken);

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
        Task<int> SumAsync(IQueryable<int> source);

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
        Task<int> SumAsync(IQueryable<int> source, CancellationToken cancellationToken);

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
        Task<int?> SumAsync(IQueryable<int?> source);

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
        Task<int?> SumAsync(IQueryable<int?> source, CancellationToken cancellationToken);


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
        Task<long> SumAsync(IQueryable<long> source);

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
        Task<long> SumAsync(IQueryable<long> source, CancellationToken cancellationToken);

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
        Task<long?> SumAsync(IQueryable<long?> source);

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
        Task<long?> SumAsync(IQueryable<long?> source, CancellationToken cancellationToken);

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
        Task<float> SumAsync(IQueryable<float> source);

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
        Task<float> SumAsync(IQueryable<float> source, CancellationToken cancellationToken);

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
        Task<float?> SumAsync(IQueryable<float?> source);

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
        Task<float?> SumAsync(IQueryable<float?> source, CancellationToken cancellationToken);

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
        Task<double> SumAsync(IQueryable<double> source);

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
        Task<double> SumAsync(IQueryable<double> source, CancellationToken cancellationToken);

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
        Task<double?> SumAsync(IQueryable<double?> source);

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
        Task<double?> SumAsync(IQueryable<double?> source, CancellationToken cancellationToken);

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
        Task<decimal> SumAsync(IQueryable<decimal> source);

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
        Task<decimal> SumAsync(IQueryable<decimal> source, CancellationToken cancellationToken);

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
        Task<decimal?> SumAsync(IQueryable<decimal?> source);

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
        Task<decimal?> SumAsync(IQueryable<decimal?> source, CancellationToken cancellationToken);

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
        Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector);

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
        Task<int> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken);

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
        Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector);

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
        Task<int?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken);

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
        Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector);

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
        Task<long> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken);

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
        Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector);

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
        Task<long?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken);

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
        Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector);

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
        Task<float> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken);

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
        Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector);

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
        Task<float?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken);

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
        Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector);

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
        Task<double> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken);

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
        Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector);

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
        Task<double?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken);

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
        Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector);

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
        Task<decimal> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken);

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
        Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector);

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
        Task<decimal?> SumAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken);

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
        Task<double> AverageAsync(IQueryable<int> source);

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
        Task<double> AverageAsync(IQueryable<int> source, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync(IQueryable<int?> source);

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
        Task<double?> AverageAsync(IQueryable<int?> source, CancellationToken cancellationToken);

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
        Task<double> AverageAsync(IQueryable<long> source);

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
        Task<double> AverageAsync(IQueryable<long> source, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync(IQueryable<long?> source);

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
        Task<double?> AverageAsync(IQueryable<long?> source, CancellationToken cancellationToken);

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
        Task<float> AverageAsync(IQueryable<float> source);

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
        Task<float> AverageAsync(IQueryable<float> source, CancellationToken cancellationToken);

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
        Task<float?> AverageAsync(IQueryable<float?> source);

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
        Task<float?> AverageAsync(IQueryable<float?> source, CancellationToken cancellationToken);

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
        Task<double> AverageAsync(IQueryable<double> source);

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
        Task<double> AverageAsync(IQueryable<double> source, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync(IQueryable<double?> source);

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
        Task<double?> AverageAsync(IQueryable<double?> source, CancellationToken cancellationToken);

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
        Task<decimal> AverageAsync(IQueryable<decimal> source);

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
        Task<decimal> AverageAsync(IQueryable<decimal> source, CancellationToken cancellationToken);
        
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
        Task<decimal?> AverageAsync(IQueryable<decimal?> source);

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
        Task<decimal?> AverageAsync(IQueryable<decimal?> source, CancellationToken cancellationToken);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int>> selector, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, int?>> selector, CancellationToken cancellationToken);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long>> selector, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, long?>> selector, CancellationToken cancellationToken);

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
        Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector);

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
        Task<float> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float>> selector, CancellationToken cancellationToken);

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
        Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector);

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
        Task<float?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, float?>> selector, CancellationToken cancellationToken);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector);

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
        Task<double> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double>> selector, CancellationToken cancellationToken);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector);

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
        Task<double?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, double?>> selector, CancellationToken cancellationToken);

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
        Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector);

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
        Task<decimal> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal>> selector, CancellationToken cancellationToken);

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
        Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector);

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
        Task<decimal?> AverageAsync<TSource>(IQueryable<TSource> source, Expression<Func<TSource, decimal?>> selector, CancellationToken cancellationToken);
    }
}