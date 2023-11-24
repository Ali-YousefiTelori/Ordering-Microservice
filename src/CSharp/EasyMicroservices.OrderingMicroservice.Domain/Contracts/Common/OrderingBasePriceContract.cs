using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.Contracts.Common;
using System;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class OrderingBasePriceContract : PriceContract, IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public string UniqueIdentity { get; set; }
    }
}
