namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class UpdateOrderRequestContract : CreateOrderRequestContract
    {
        public long Id { get; set; }
    }
}
