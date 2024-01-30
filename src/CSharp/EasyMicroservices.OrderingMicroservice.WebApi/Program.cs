using CompileTimeMapper;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Contexts;
using EasyMicroservices.OrderingMicroservice.Database.Entities;

namespace EasyMicroservices.OrderingMicroservice.WebApi
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var app = CreateBuilder(args);
            var build = await app.BuildWithUseCors<OrderContext>(null, true);
            build.MapControllers();
            build.Run();
        }

        static WebApplicationBuilder CreateBuilder(string[] args)
        {
            var app = StartUpExtensions.Create<OrderContext>(args);
            app.Services.Builder<OrderContext>("Ordering")
                .UseDefaultSwaggerOptions();
            app.Services.AddTransient<IEntityFrameworkCoreDatabaseBuilder, DatabaseBuilder>();
            app.Services.AddTransient(serviceProvider => new OrderContext(serviceProvider.GetService<IEntityFrameworkCoreDatabaseBuilder>()));
            return app;
        }
    }
}