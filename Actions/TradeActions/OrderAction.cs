using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Core.Intangible.Enumeration;
using MXTires.Microdata.Core.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core.Actions.TradeActions
{
    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public class OrderAction : TradeAction
    {
        /// <summary>
        /// DeliveryMethod  - A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonProperty("deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
        
    }
}
