using EasyMicroservices.Cores.Relational.EntityFrameworkCore.Intrerfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EasyMicroservices.OrderingMicroservice
{
    public class DatabaseBuilder : IEntityFrameworkCoreDatabaseBuilder
    {
        IConfiguration _configuration;
        public DatabaseBuilder(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("OrderDatabase");
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("local"));
        }
    }
}
