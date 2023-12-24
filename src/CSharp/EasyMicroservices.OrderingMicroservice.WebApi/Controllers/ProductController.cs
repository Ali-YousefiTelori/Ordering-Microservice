using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyMicroservices.OrderingMicroservice.WebApi.Controllers;

public class ProductController : MultilingualSimpleQueryServiceController<ProductEntity, CreateProductRequestContract, UpdateProductRequestContract, ProductContract, ProductLanguageContract, long>
{
    public ProductController(IUnitOfWork unitOfWork) : base(unitOfWork)
    {

    }

    protected override Func<IQueryable<ProductEntity>, IQueryable<ProductEntity>> OnGetAllQuery()
    {
        return (q) => q.Include(x => x.Prices);
    }

    protected override Func<IQueryable<ProductEntity>, IQueryable<ProductEntity>> OnGetQuery()
    {
        return OnGetAllQuery();
    }
}
