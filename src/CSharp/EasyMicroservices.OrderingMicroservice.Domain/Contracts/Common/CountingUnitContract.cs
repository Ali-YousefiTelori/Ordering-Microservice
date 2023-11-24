using EasyMicroservices.ContentsMicroservice.Clients.Attributes;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class CountingUnitContract : CountingUnitBaseContract
    {
        public long Id { get; set; }

        [ContentLanguage]
        public string Name { get; set; }

        [ContentLanguage]
        public string Description { get; set; }
    }
}
