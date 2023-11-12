using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class OrderEntity : OrderSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }
        public long ProductId { get; set; }

        public OrderEntity Parent { get; set; }
        public ProductEntity Product { get; set; }

        public ICollection<OrderEntity> Children { get; set; }
    }
}
