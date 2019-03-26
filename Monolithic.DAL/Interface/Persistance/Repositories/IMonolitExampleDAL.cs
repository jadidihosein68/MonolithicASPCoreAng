using Monolithic.Model;
using System.Collections.Generic;

namespace Monolithic.DAL.Interface.Persistance.Repositories
{
    public interface IMonolitExampleDAL
    {
        void AddRange(IEnumerable<MonolitExampleModel> DataSet);
    }
}
