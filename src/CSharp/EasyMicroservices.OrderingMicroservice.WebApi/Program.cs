using CompileTimeMapper;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Contexts;
using EasyMicroservices.OrderingMicroservice.Database.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace EasyMicroservices.OrderingMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            UnitOfWork.MapperTypeAssembly = typeof(OrderEntity_CreateOrderRequestContract_Mapper);
            var build = await app.Build<OrderContext>();
            build.MapControllers();
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<OrderContext>(args);
            app.Services.Builder<OrderContext>();
            app.Services.AddScoped((serviceProvider) => new UnitOfWork(serviceProvider));
            app.Services.AddScoped((serviceProvider) => serviceProvider.GetService<IUnitOfWork>().GetLongContractLogic<OrderEntity, CreateOrderRequestContract, UpdateOrderRequestContract, OrderContract>());
            app.Services.AddTransient(serviceProvider => new OrderContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            app.Services.AddScoped<IEntityFrameworkCoreDatabaseBuilder>(serviceProvider => new DatabaseBuilder(serviceProvider.GetService<IConfiguration>()));
            StartUpExtensions.AddWhiteLabel("Ordering", "RootAddresses:WhiteLabel");
            return app;
        }
    }
}