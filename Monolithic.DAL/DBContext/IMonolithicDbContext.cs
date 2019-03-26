using Microsoft.EntityFrameworkCore;
using Monolithic.Model;

namespace Monolithic.DAL.DBContext
{
    public interface IMonolithicDbContext
    {

        DbSet<MonolitExampleModel> MonolitExampleModel { get; set; }

    }
}