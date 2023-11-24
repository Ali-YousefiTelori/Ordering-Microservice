using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class OrderBaseContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public List<OrderPriceContract> Prices { get; set; }
        public long? ParentId { get; set; }

        public long ProductId { get; set; }
        public ProductContract Product { get; set; }

        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
