using EStore.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace EStore.FluentAPI
{
    public class OrderCF : IEntityTypeConfiguration<order>
    {
        public void Configure(EntityTypeBuilder<order> builder)
        {
            builder.HasOne<staff>()
                .WithMany()
                .HasForeignKey(p => p.id_staff);
            builder.HasOne<customer>()
                .WithMany()
                .HasForeignKey(c => c.id_customer);
        }

    }
}
