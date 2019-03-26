using Microsoft.EntityFrameworkCore;
using Monolithic.DAL.Persistence.EntityConfigurations;
using Monolithic.Model;

namespace Monolithic.DAL.DBContext
{
    public class MonolithicDbContext : DbContext, IMonolithicDbContext
    {
        public MonolithicDbContext(DbContextOptions<MonolithicDbContext> options) : base(options) { }

        // Models
        public DbSet<MonolitExampleModel> MonolitExampleModel { get; set; }
        //        public DbQuery<TweetsSummary> TweetsSummary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //    modelBuilder.Query<TweetsSummary> ().ToView ("View_TweetsSummary");
            modelBuilder.ApplyConfiguration(new MonolitExampleModelConfigration());

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    }
}