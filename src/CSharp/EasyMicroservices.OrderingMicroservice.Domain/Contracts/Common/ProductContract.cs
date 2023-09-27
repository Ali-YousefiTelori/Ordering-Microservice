using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using System;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class ProductContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}
