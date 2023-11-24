using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Database.Schemas;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class OrderPriceEntity : PriceSchema, IIdSchema<long>
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public OrderEntity Order { get; set; }
    }
}
