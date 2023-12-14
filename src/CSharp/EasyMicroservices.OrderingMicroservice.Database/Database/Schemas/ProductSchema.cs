using EasyMicroservices.Cores.Database.Schemas;
using EasyMicroservices.Domain.DataTypes;

namespace EasyMicroservices.OrderingMicroservice.Database.Schemas
{
    public class ProductSchema : FullAbilitySchema
    {
        /// <summary>
        ///The ExternalServiceIdentifier is a unique identifier that corresponds to products or services within an external fiscal system,
        ///specifically designated for tax and revenue tracking purposes.
        ///This identifier is used to ensure accurate and consistent financial reporting and is typically required when integrating with external tax systems or government revenue services.
        ///This ID facilitates seamless communication and data exchange between the software application
        ///and external fiscal entities by providing a standardized reference point that unambiguously links each item or service to its financial transactions
        ///and tax-related data. It is crucial for maintaining the integrity of financial records and complying with regulatory audit requirements.
        ///By utilizing the ExternalServiceIdentifier, developers and accountants can easily trace the financial footprint of each product or service, enabling precise tax calculations,
        ///financial analysis, and strategic planning.
        ///This description gives a clear understanding of the purpose of the identifier and its importance in the context of financial operations and integrations with external systems.
        /// </summary>
        public string ExternalServiceIdentifier { get; set; }
    }
}
