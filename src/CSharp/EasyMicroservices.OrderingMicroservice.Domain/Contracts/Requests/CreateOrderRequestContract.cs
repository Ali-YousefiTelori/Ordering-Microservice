using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateOrderRequestContract : IUniqueIdentitySchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateOrderRequestContract> Children { get; set; }
    }
}