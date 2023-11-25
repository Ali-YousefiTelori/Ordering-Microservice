namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class UpdateCountingUnitRequestContract : CreateCountingUnitRequestContract
    {
        public long Id { get; set; }
    }
}
