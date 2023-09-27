using EasyMicroservices.Cores.Interfaces;
using EasyMicroservices.Domain.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.OrderingMicroservice.Contracts.Requests
{
    public class CreateProductRequestContract : IUniqueIdentitySchema
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public CurrencyCodeType CurrencyCode { get; set; }
        public string UniqueIdentity { get; set; }
        public long? ParentId { get; set; }

        public List<CreateProductRequestContract> Children { get; set; }
    }
}
