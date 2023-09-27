using EasyMicroservices.ContentsMicroservice.Clients.Helpers;
using EasyMicroservices.Cores.AspCoreApi;
using EasyMicroservices.Cores.AspEntityFrameworkCoreApi.Interfaces;
using EasyMicroservices.Cores.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Contracts.Common;
using EasyMicroservices.OrderingMicroservice.Contracts.Requests;
using EasyMicroservices.OrderingMicroservice.Database.Entities;
using EasyMicroservices.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace EasyMicroservices.OrderingMicroservice.WebApi.Controllers
{
    public class ProductController : SimpleQueryServiceController<ProductEntity, CreateProductRequestContract, UpdateProductRequestContract, ProductContract, long>
    {
        private readonly IConfiguration _config;
        private readonly ContentLanguageHelper _contentHelper;
        readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork, IConfiguration config) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _config = config;
            _contentHelper = new(new Contents.GeneratedServices.ContentClient(_config.GetValue<string>("RootAddresses:Content"), new HttpClient()));
        }


        public override async Task<MessageContract<long>> Add(CreateProductRequestContract request, CancellationToken cancellationToken = default)
        {
            var result = await base.Add(request, cancellationToken);
            if (result)
            {
                var addedItem = await GetById(new Cores.Contracts.Requests.GetIdRequestContract<long> { Id = result.Result });
                request.UniqueIdentity = addedItem.Result.UniqueIdentity;
                var addContent = await _contentHelper.AddToContentLanguage(request);
                if (!addContent.IsSuccess)
                    return addContent.ToContract<long>();
            }
            return result;
        }

        public override async Task<MessageContract<ProductContract>> Update(UpdateProductRequestContract request, CancellationToken cancellationToken = default)
        {
            var result = await base.Update(request, cancellationToken);
            if (result)
            {
                var addedItem = await GetById(new Cores.Contracts.Requests.GetIdRequestContract<long> { Id = request.Id });
                request.UniqueIdentity = addedItem.Result.UniqueIdentity;
                var updateToContent = await _contentHelper.UpdateToContentLanguage(request);
                if (!updateToContent.IsSuccess)
                    return updateToContent.ToContract<ProductContract>();
            }
            return result;
        }

        [HttpPost]
        public async Task<ListMessageContract<ProductContract>> GetAllByLanguage(GetByLanguageRequestContract request, CancellationToken cancellationToken = default)
        {
            var result = await base.GetAll(cancellationToken);
            if (result)
            {
                await _contentHelper.ResolveContentLanguage(result.Result, request.Language);
            }
            return result;
        }

        [HttpPost]
        public async Task<MessageContract<ProductLanguageContract>> GetByIdAllLanguage(GetIdRequestContract<long> request, CancellationToken cancellationToken = default)
        {
            var result = await base.GetById(request.Id, cancellationToken);
            if (result)
            {
                var mapped = _unitOfWork.GetMapper().Map<ProductLanguageContract>(result.Result);
                await _contentHelper.ResolveContentAllLanguage(mapped);
                return mapped;
            }
            return result.ToContract<ProductLanguageContract>();
        }
    }
}
