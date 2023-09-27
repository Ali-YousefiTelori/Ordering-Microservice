using EasyMicroservices.ContentsMicroservice.Clients.Attributes;
using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Common
{
    public class ProductLanguageContract : IUniqueIdentitySchema, ISoftDeleteSchema, IDateTimeSchema
    {
        public long Id { get; set; }
        [ContentLanguage]
        public List<LanguageDataContract> Names { get; set; }
        [ContentLanguage]
        public List<LanguageDataContract> Descriptions { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public string UniqueIdentity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedDateTime { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? ModificationDateTime { get; set; }
    }
}