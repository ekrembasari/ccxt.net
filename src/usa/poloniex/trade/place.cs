﻿using Newtonsoft.Json;
using OdinSdk.BaseLib.Coin.Trade;
using OdinSdk.BaseLib.Coin.Types;
using OdinSdk.BaseLib.Configuration;
using System;
using System.Collections.Generic;

namespace CCXT.NET.Poloniex.Trade
{
    /// <summary>
    ///
    /// </summary>
    public class PPlaceOrders : OdinSdk.BaseLib.Coin.Trade.MyOrders, IMyOrders
    {
        /// <summary>
        /// 접수된 주문 ID
        /// </summary>
        [JsonProperty(PropertyName = "orderNumber")]
        public string orderId
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "resultingTrades")]
        public List<PPlaceOrderItem> resultingTrades
        {
            get;
            set;
        }
    }

    /// <summary>
    ///
    /// </summary>
    public class PPlaceOrderItem : OdinSdk.BaseLib.Coin.Trade.MyOrderItem, IMyOrderItem
    {
        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "tradeID")]
        public string tradeId
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public override decimal quantity
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "rate")]
        public override decimal price
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public override decimal amount
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "date")]
        private DateTime timeValue
        {
            set
            {
                timestamp = CUnixTime.ConvertToUnixTimeMilli(value);
            }
        }

        /// <summary>
        ///
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        private string sideValue
        {
            set
            {
                sideType = SideTypeConverter.FromString(value);
            }
        }
    }
}