using EasyMicroservices.Cores.Relational.EntityFrameworkCore;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.OrderingMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EasyMicroservices.OrderingMicroservice.Database.Contexts
{
    public class OrderContext : RelationalCoreContext
    {
        readonly IEntityFrameworkCoreDatabaseBuilder _builder;
        public OrderContext(IEntityFrameworkCoreDatabaseBuilder builder)
        {
            _builder = builder;
        }

        public DbSet<OrderEntity> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _builder?.OnConfiguring(optionsBuilder);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.AutoModelCreating(modelBuilder);
        }
    }
}