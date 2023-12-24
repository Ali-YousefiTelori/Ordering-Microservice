using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Entities;

namespace EasyMicroservices.OrderingMicroservice.WebApi.Controllers;

public class CountingUnitController : MultilingualSimpleQueryServiceController<CountingUnitEntity, CreateCountingUnitRequestContract, UpdateCountingUnitRequestContract, CountingUnitContract, CountingUnitLanguageContract, long>
{
    public CountingUnitController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
