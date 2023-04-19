using EStore.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EStore.FluentAPI
{
    public class OrderDetailCF : IEntityTypeConfiguration<orderDetail>
    {
        public void Configure(EntityTypeBuilder<orderDetail> builder)
        {
            builder.HasOne<order>()
                .WithMany()
                .HasForeignKey(p => p.id_order);
            builder.HasOne<product>()
                .WithMany()
                .HasForeignKey(c => c.id_product);
        }
    }
}
