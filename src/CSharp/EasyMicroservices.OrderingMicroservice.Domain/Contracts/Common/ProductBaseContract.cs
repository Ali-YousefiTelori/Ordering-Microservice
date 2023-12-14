using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class ProductBaseContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public string ExternalServiceIdentifier { get; set; }
        public List<ProductPriceContract> Prices { get; set; }
        public long? ParentId { get; set; }
        public long? CountingUnitId { get; set; }
        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
