namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class ProductPriceContract : OrderingBasePriceContract
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
    }
}
