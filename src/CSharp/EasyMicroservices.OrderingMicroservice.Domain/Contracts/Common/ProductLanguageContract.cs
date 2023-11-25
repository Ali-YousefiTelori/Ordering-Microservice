using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class ProductLanguageContract : ProductBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(ProductContract.Name))]
        public List<LanguageDataContract> Names { get; set; }

        [ContentLanguage(nameof(ProductContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
    }
}