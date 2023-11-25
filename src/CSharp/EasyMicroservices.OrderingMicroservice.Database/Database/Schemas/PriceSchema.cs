using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.OrderingMicroservice.Database.Schemas
{
    public class PriceSchema : FullAbilitySchema
    {
        public decimal Amount { get; set; }
        public AmountType AmountType { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public PriceType Type { get; set; }
    }
}

