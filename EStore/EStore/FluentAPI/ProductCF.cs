using EStore.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EStore.FluentAPI
{
    public class ProductCF : IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.HasOne<category>()
                .WithMany()
                .HasForeignKey(p => p.id_category);
        }
    }
}
