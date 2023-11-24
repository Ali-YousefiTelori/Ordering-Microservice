using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.OrderingMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.OrderingMicroservice.Database.Contexts
{
    public class OrderContext : RelationalCoreContext
    {
        public OrderContext(IEntityFrameworkCoreDatabaseBuilder builder) : base(builder)
        {
        }

        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<OrderPriceEntity> OrderPrices { get; set; }
        public DbSet<ProductPriceEntity> ProductPrices { get; set; }
        public DbSet<CountingUnitEntity> CountingUnits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.AutoModelCreating(modelBuilder);
        }
    }
}