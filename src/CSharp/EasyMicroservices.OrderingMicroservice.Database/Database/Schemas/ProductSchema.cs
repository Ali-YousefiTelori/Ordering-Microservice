using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.OrderingMicroservice.Database.Schemas
{
    public class ProductSchema : FullAbilitySchema
    {
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
    }
}
