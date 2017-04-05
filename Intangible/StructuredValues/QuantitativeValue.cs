﻿#region License
// Copyright (c) 2015 1010Tires.com
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using MXTires.Microdata.Core.Intangible;
using MXTires.Microdata.Core.Intangible.StructuredValues;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core
{
    /// <summary>
    /// A point value or interval for product characteristics and other purposes.
    /// </summary>
    public class QuantitativeValue : StructuredValue
    {
        /// <summary>
        /// Gets or sets the additional property.
        /// </summary>
        /// <value>The additional property.</value>
        [JsonProperty("additionalProperty")]
        public PropertyValue AdditionalProperty { get; set; }

        /// <summary>
        /// Number - The upper value of some characteristic or property.
        /// </summary>
        /// <value>The maximum value.</value>
        [JsonProperty("maxValue")]
        public float? MaxValue { get; set; }

        /// <summary>
        /// Number - The lower value of some characteristic or property.
        /// </summary>
        /// <value>The minimum value.</value>
        [JsonProperty("minValue")]
        public float? MinValue { get; set; }

        /// <summary>
        /// Text - The unit of measurement given using the UN/CEFACT Common Code (3 characters).
        /// </summary>
        /// <value>The unit code.</value>
        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        /// <summary>
        /// Number - The value of the product characteristic.
        /// </summary>
        /// <value>The value.</value>
        [JsonProperty("value")]
        public float Value { get; set; }

        /// <summary>
        /// Enumeration or StructuredValue - A pointer to a secondary value that provides additional information on the original value, e.g. a reference temperature.
        /// </summary>
        /// <value>The value reference.</value>
        [JsonProperty("valueReference")]
        public object ValueReference { get; set; }
    }
}
