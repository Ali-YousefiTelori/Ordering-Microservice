namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class UpdateProductRequestContract : CreateProductRequestContract
    {
        public long Id { get; set; }
    }
}
