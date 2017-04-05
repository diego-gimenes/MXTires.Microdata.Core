﻿#region License
// Copyright (c) 2016 1010Tires.com
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

using MXTires.Microdata.Core.Intangible.Services;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core.Intangible
{
    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    public class BroadcastChannel : Thing
    {
        /// <summary>
        /// Text - The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
        /// </summary>
        [JsonProperty("broadcastChannelId")]
        public string BroadcastChannelId { get; set; }

        /// <summary>
        /// Text - The type of service required to have access to the channel (e.g. Standard or Premium).
        /// </summary>
        [JsonProperty("broadcastServiceTier")]
        public string BroadcastServiceTier { get; set; }

        /// <summary>
        /// CableOrSatelliteService - The CableOrSatelliteService offering the channel.
        /// </summary>
        [JsonProperty("inBroadcastLineup")]
        public CableOrSatelliteService InBroadcastLineup { get; set; }

        /// <summary>
        /// BroadcastService - The BroadcastService offered on this channel.
        /// </summary>
        [JsonProperty("providesBroadcastService")]
        public BroadcastService ProvidesBroadcastService { get; set; }
    }
}
