using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateProductRequestContract : IUniqueIdentitySchema
    {
        public string ExternalServiceIdentifier { get; set; }
        [ContentLanguage(nameof(OrderContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
        [ContentLanguage(nameof(OrderContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }

        public long? CountingUnitId { get; set; }
        public List<ProductPriceContract> Prices { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateProductRequestContract> Children { get; set; }
    }
}
