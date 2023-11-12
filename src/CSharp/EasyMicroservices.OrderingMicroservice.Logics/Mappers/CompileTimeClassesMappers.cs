using System.Threading.Tasks;
using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using System.Linq;

namespace CompileTimeMapper
{
    public class OrderEntity_CreateOrderRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public OrderEntity_CreateOrderRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class OrderEntity_OrderContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public OrderEntity_OrderContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = fromObject.Price.CurrencyCode,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                Product = _mapper.Map<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Product, uniqueRecordId, language, parameters),
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                Product = _mapper.Map<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract>(fromObject.Product, uniqueRecordId, language, parameters),
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = fromObject.Price.CurrencyCode,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                Product = await _mapper.MapAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Product, uniqueRecordId, language, parameters),
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                Product = await _mapper.MapAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract>(fromObject.Product, uniqueRecordId, language, parameters),
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class OrderEntity_UpdateOrderRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public OrderEntity_UpdateOrderRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateOrderRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                ProductId = fromObject.ProductId,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateOrderRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class ProductEntity_CreateProductRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public ProductEntity_CreateProductRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class ProductEntity_ProductContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public ProductEntity_ProductContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = fromObject.Price.CurrencyCode,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = fromObject.Price.CurrencyCode,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class ProductEntity_UpdateProductRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public ProductEntity_UpdateProductRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract()
            {
                Children = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity>(fromObject.Children, uniqueRecordId, language, parameters),
                CurrencyCode = fromObject.Price.CurrencyCode,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                PriceAmount = fromObject.Price.Amount,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract()
            {
                Children = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateProductRequestContract>(fromObject.Children, uniqueRecordId, language, parameters),
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Price = new EasyMicroservices.Domain.Contracts.Common.PriceContract() { Amount = fromObject.PriceAmount, CurrencyCode = fromObject.CurrencyCode },
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateProductRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
}