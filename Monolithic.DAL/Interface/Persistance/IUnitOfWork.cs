using System.Threading.Tasks;
using Monolithic.DAL.Interface.Persistance.Repositories;

namespace Monolithic.DAL.Interface.Persistance
{
    public interface IUnitOfWork
    {

        IMonolitExampleDAL MonolitExampleDAL { get; }

        void Complite();
        Task CompliteAsync();

    }
}