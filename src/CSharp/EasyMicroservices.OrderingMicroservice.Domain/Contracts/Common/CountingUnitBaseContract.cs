using EasyMicroservices.Cores.Interfaces;
using System;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class CountingUnitBaseContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}