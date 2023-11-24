using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateCountingUnitRequestContract : IUniqueIdentitySchema
    {
        [ContentLanguage(nameof(OrderContract.Name))]
        public List<LanguageDataContract> Names { get; set; }
        [ContentLanguage(nameof(OrderContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
        public string UniqueIdentity { get; set; }
    }
}