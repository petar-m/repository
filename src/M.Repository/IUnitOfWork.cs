using System.Threading.Tasks;

namespace M.Repository
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        void Rollback();
    }
}
