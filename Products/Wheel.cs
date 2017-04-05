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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core
{
    /// <summary>
    /// Represents Wheel product
    /// </summary>
    public class Wheel : Product
    {
        /// <summary>
        /// Specific product type definition
        /// </summary>
        [JsonProperty("@type", Order = 2)]
        public new string Type { get { return "Product/Wheel"; } }

        string additionalType = "http://www.productontology.org/id/Wheel";
        /// <summary>
        /// Additional type of product override
        /// </summary>
        [JsonProperty("additionalType")]
        public new string AdditionalType { get { return additionalType; } set { additionalType = value; } }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Wheel()
        {
            base.SameAs = new List<string>();
            SameAs.Add("http://en.wikipedia.org/wiki/Wheel");
            SameAs.Add("http://www.1010tires.com/About/Wheel-Tech");
        }
    }
}
