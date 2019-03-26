using System.Threading.Tasks;
using Monolithic.DAL.Interface.Persistance.Repositories;
using Monolithic.DAL.Persistence.Repositories;
using Monolithic.DAL.DBContext;
using Monolithic.DAL.Interface.Persistance;

namespace Monolithic.DAL.Persistence {
    public class UnitOfWork : IUnitOfWork {
        private readonly MonolithicDbContext context;

        public IMonolitExampleDAL MonolitExampleDAL { get; private set; }


        public UnitOfWork (MonolithicDbContext _context) {
            context = _context;
            MonolitExampleDAL = new MonolitExampleDAL(_context);
        }

        public void Complite () {
            context.SaveChanges ();
        }

        public async Task CompliteAsync () {
            await context.SaveChangesAsync ();

        }

    }
}