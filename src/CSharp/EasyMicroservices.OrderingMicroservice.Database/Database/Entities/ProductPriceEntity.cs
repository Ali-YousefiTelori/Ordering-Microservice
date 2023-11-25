using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Database.Schemas;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class ProductPriceEntity : PriceSchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}

