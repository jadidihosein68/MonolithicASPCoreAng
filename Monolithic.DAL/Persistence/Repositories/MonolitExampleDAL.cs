using Monolithic.DAL.Interface.Persistance.Repositories;
using Monolithic.DAL.DBContext;
using Monolithic.Model;
using System.Collections.Generic;

namespace Monolithic.DAL.Persistence.Repositories
{
    public class MonolitExampleDAL : IMonolitExampleDAL
    {
        private readonly IMonolithicDbContext context;
        public MonolitExampleDAL(IMonolithicDbContext _context)
        {
            context = _context;
        }

        public void AddRange(IEnumerable<MonolitExampleModel> DataSet)
        {
            context.MonolitExampleModel.AddRange(DataSet);
        }
    }
}
