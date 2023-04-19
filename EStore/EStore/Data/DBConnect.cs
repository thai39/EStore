using EStore.FluentAPI;
using EStore.Model;
using Microsoft.EntityFrameworkCore;

namespace EStore.Data
{
    public class DBConnect : DbContext
    {
        public DBConnect(DbContextOptions<DBConnect> options) : base(options)
        {

        }
        public DbSet<category> category { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<staff> staff { get; set; }
        public DbSet<customer> customer { get; set; }
        public DbSet<order> orders { get; set; }
        public DbSet<orderDetail> order_detail { get; set; }
        public DbSet<account> account { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCF());
            modelBuilder.ApplyConfiguration(new OrderCF());
            modelBuilder.ApplyConfiguration(new OrderDetailCF());
        }
    }
}
