﻿namespace EasyMicroservices.OrderingMicroservice.DataTypes
{
    public enum OrderStatusType : byte
    {
        /// <summary>
        /// value is none, Never use the None to return values
        /// </summary>
        None = 0,
        /// <summary>
        /// error value is default
        /// </summary>
        Default = 1,
        /// <summary>
        /// for the filter values from web admin panel you can sent all for types
        /// </summary>
        All = 2,
        /// <summary>
        /// there is other error that is not in the types
        /// </summary>
        Other = 3,
        /// <summary>
        /// the error type is uknown to us
        /// </summary>
        Unknown = 4,
        /// <summary>
        /// there is nothing to show or validate error
        /// </summary>
        Nothing = 5,

        Created = 6,
        Purchasing = 7,
        InProgress = 8,
        Purchased = 9,
        Canceled = 10,
        Failed = 11
    }
}
