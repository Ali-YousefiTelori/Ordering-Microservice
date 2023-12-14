using System.Threading.Tasks;
using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
using EasyMicroservices.Mapper.Interfaces;
using System.Linq;

namespace CompileTimeMapper
{
    public class CountingUnitEntity_CountingUnitContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public CountingUnitEntity_CountingUnitContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract()
            {
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.CountingUnitContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class CountingUnitEntity_CreateCountingUnitRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public CountingUnitEntity_CreateCountingUnitRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract()
            {
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract()
            {
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.CreateCountingUnitRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
    public class CountingUnitEntity_UpdateCountingUnitRequestContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public CountingUnitEntity_UpdateCountingUnitRequestContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                Id = fromObject.Id,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract()
            {
                Id = fromObject.Id,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity()
            {
                Id = fromObject.Id,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract()
            {
                Id = fromObject.Id,
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.CountingUnitEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Requests.UpdateCountingUnitRequestContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
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
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
    public class OrderPriceEntity_OrderPriceContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public OrderPriceEntity_OrderPriceContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity()
            {
                Amount = fromObject.Amount,
                AmountType = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                OrderId = fromObject.OrderId,
                Type = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract()
            {
                Amount = fromObject.Amount,
                AmountType = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                OrderId = fromObject.OrderId,
                Type = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity()
            {
                Amount = fromObject.Amount,
                AmountType = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                OrderId = fromObject.OrderId,
                Type = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract()
            {
                Amount = fromObject.Amount,
                AmountType = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                OrderId = fromObject.OrderId,
                Type = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.OrderPriceEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.OrderPriceContract)fromObject, uniqueRecordId, language, parameters);
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                CreationDateTime = fromObject.CreationDateTime,
                DeletedDateTime = fromObject.DeletedDateTime,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = _mapper.MapToList<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity>(fromObject.Prices, uniqueRecordId, language, parameters),
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
                CountingUnitId = fromObject.CountingUnitId,
                ExternalServiceIdentifier = fromObject.ExternalServiceIdentifier,
                Id = fromObject.Id,
                ParentId = fromObject.ParentId,
                Prices = await _mapper.MapToListAsync<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract>(fromObject.Prices, uniqueRecordId, language, parameters),
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
    public class ProductPriceEntity_ProductPriceContract_Mapper : IMapper
    {
        readonly IMapperProvider _mapper;
        public ProductPriceEntity_ProductPriceContract_Mapper(IMapperProvider mapper)
        {
            _mapper = mapper;
        }

        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity()
            {
                Amount = fromObject.Amount,
                AmountType = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ProductId = fromObject.ProductId,
                Type = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract()
            {
                Amount = fromObject.Amount,
                AmountType = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ProductId = fromObject.ProductId,
                Type = _mapper.Map<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity()
            {
                Amount = fromObject.Amount,
                AmountType = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ProductId = fromObject.ProductId,
                Type = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }

        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract()
            {
                Amount = fromObject.Amount,
                AmountType = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.AmountType>(fromObject.AmountType, uniqueRecordId, language, parameters),
                CreationDateTime = fromObject.CreationDateTime,
                CurrencyCode = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.CurrencyCodeType>(fromObject.CurrencyCode, uniqueRecordId, language, parameters),
                DeletedDateTime = fromObject.DeletedDateTime,
                Id = fromObject.Id,
                IsDeleted = fromObject.IsDeleted,
                ModificationDateTime = fromObject.ModificationDateTime,
                ProductId = fromObject.ProductId,
                Type = await _mapper.MapAsync<global::EasyMicroservices.Domain.DataTypes.PriceType>(fromObject.Type, uniqueRecordId, language, parameters),
                UniqueIdentity = fromObject.UniqueIdentity,
            };
            return mapped;
        }
        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity))
                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity)fromObject, uniqueRecordId, language, parameters);
            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract)fromObject, uniqueRecordId, language, parameters);
        }
        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
        {
            if (fromObject == default)
                return default;
            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity))
                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.ProductPriceEntity)fromObject, uniqueRecordId, language, parameters);
            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.ProductPriceContract)fromObject, uniqueRecordId, language, parameters);
        }
    }
}