﻿using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Entities;

namespace EasyMicroservices.OrderingMicroservice.WebApi.Controllers;

public class OrderController : MultilingualSimpleQueryServiceController<OrderEntity, CreateOrderRequestContract, UpdateOrderRequestContract, OrderContract, OrderLanguageContract, long>
{
    public OrderController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {
    }
}
