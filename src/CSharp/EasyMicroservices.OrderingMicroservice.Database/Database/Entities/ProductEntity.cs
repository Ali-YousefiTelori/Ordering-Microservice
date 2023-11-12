using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class ProductEntity : ProductSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }
        public ProductEntity Parent { get; set; }
        public ICollection<ProductEntity> Children { get; set; }
        public ICollection<OrderEntity> Orders { get; set; }
    }
}
