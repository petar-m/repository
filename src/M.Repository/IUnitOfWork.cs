using System.Threading.Tasks;

namespace M.Repository
{
    /// <summary>
    /// Represents a logic to track and persist entity changes.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Persists all changes as a single transaction.
        /// </summary>
        void Commit();

        /// <summary>
        /// Persists all changes as a single transaction asynchronously.
        /// </summary>
        /// <returns>A task representing the persistence result.</returns>
        Task CommitAsync();

        /// <summary>
        /// Discards all changes.
        /// </summary>
        void Rollback();
    }
}
