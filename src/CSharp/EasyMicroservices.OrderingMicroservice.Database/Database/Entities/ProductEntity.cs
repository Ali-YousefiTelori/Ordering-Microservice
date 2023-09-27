using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Database.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class ProductEntity : ProductSchema, IIdSchema<long>
    {
        public long Id { get; set; }

        public long? ParentId { get; set; }
        public ProductEntity Parent { get; set; }
        public ICollection<ProductEntity> Children { get; set; }
    }
}
