using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Entities;

namespace EasyMicroservices.OrderingMicroservice.WebApi.Controllers
{
    public class OrderController : SimpleQueryServiceController<OrderEntity, CreateOrderRequestContract, UpdateOrderRequestContract, OrderContract, long>
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(IUnitOfWork unitOfWork) : base(null)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
