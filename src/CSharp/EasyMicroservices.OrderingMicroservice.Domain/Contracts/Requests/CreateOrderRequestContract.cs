using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateOrderRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage]
        public List<LanguageDataContract> Names { get; set; }
        [ContentLanguage]
        public List<LanguageDataContract> Descriptions { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateOrderRequestContract> Children { get; set; }
    }
}