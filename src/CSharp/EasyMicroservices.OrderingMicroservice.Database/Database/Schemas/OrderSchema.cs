using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.OrderingMicroservice.Database.Schemas
{
    public class OrderSchema : FullAbilitySchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
    }
}
