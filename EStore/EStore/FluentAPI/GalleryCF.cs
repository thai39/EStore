using EStore.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EStore.FluentAPI
{
    public class GalleryCF : IEntityTypeConfiguration<gallery>
    {
        public void Configure(EntityTypeBuilder<gallery> builder)
        {
            builder.HasOne<product>()
                .WithMany()
                .HasForeignKey(x => x.proId);
        }
    }
}
