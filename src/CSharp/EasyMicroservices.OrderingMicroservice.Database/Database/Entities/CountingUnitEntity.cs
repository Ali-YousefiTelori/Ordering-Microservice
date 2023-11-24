using EasyMicroservices.Cores.Database.Schemas;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Database.Entities
{
    public class CountingUnitEntity : FullAbilityIdSchema<long>
    {
        public ICollection<ProductEntity> Products { get; set; }
    }
}
