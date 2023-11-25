using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using System.Collections.Generic;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class CountingUnitLanguageContract : CountingUnitBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage(nameof(OrderContract.Name))]
        public List<LanguageDataContract> Names { get; set; }

        [ContentLanguage(nameof(OrderContract.Description))]
        public List<LanguageDataContract> Descriptions { get; set; }
    }
}