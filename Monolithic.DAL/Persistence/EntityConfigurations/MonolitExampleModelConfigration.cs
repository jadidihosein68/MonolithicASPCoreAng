using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monolithic.Model;

namespace Monolithic.DAL.Persistence.EntityConfigurations
{
    public class MonolitExampleModelConfigration : IEntityTypeConfiguration<MonolitExampleModel>
    {
        public void Configure(EntityTypeBuilder<MonolitExampleModel> builder)
        {
            builder.HasKey(c => c.ModelId);
        }

    }
}
