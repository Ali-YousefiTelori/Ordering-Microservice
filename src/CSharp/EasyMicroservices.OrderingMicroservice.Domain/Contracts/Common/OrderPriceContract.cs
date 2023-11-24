namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class OrderPriceContract : OrderingBasePriceContract
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
    }
}
