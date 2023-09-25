//using System.Threading.Tasks;
//using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
//using EasyMicroservices.Mapper.Interfaces;
//using System.Linq;

//namespace CompileTimeMapper
//{
//    public class OrderEntity_OrderContract_Mapper : IMapper
//    {
//        readonly IMapperProvider _mapper;
//        public OrderEntity_OrderContract_Mapper(IMapperProvider mapper)
//        {
//            _mapper = mapper;
//        }
//        public global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity Map(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity()
//            {
//                Id = fromObject.Id,
//                ServiceId = fromObject.ServiceId,
//                Address = fromObject.Address,
//                Status = fromObject.Status,
//                Url = fromObject.Url,
//                TotalAmount = fromObject.TotalAmount,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract Map(global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract()
//            {
//                Id = fromObject.Id,
//                ServiceId = fromObject.ServiceId,
//                Address = fromObject.Address,
//                Status = fromObject.Status,
//                Url = fromObject.Url,
//                TotalAmount = fromObject.TotalAmount,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity> MapAsync(global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity()
//            {
//                Id = fromObject.Id,
//                ServiceId = fromObject.ServiceId,
//                Address = fromObject.Address,
//                Status = fromObject.Status,
//                Url = fromObject.Url,
//                TotalAmount = fromObject.TotalAmount,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract> MapAsync(global::EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract()
//            {
//                Id = fromObject.Id,
//                ServiceId = fromObject.ServiceId,
//                Address = fromObject.Address,
//                Status = fromObject.Status,
//                Url = fromObject.Url,
//                TotalAmount = fromObject.TotalAmount,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity

//            };
//            return mapped;
//        }
//        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity))
//                return Map((EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity)fromObject, uniqueRecordId, language, parameters);
//            return Map((EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract)fromObject, uniqueRecordId, language, parameters);
//        }
//        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity))
//                return await MapAsync((EasyMicroservices.OrderingMicroservice.Database.Entities.InvoiceEntity)fromObject, uniqueRecordId, language, parameters);
//            return await MapAsync((EasyMicroservices.OrderingMicroservice.Contracts.Common.InvoiceContract)fromObject, uniqueRecordId, language, parameters);
//        }
//    }
//}