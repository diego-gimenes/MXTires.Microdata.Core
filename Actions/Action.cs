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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MXTires.Microdata.Core.Intangible.Enumeration;
using Newtonsoft.Json.Converters;
using MXTires.Microdata.Core.Validators;

namespace MXTires.Microdata.Core
{
    /// <summary>
    /// An action performed by a direct agent and indirect participants upon a direct object. 
    /// Optionally happens at a location with the help of an inanimate instrument. 
    /// The execution of the action may produce a result. 
    /// Specific action sub-type documentation specifies the exact expectation of each argument/role. 
    /// See also blog post and Actions overview document.
    /// </summary>
    public class Action : Thing
    {
        /// <summary>
        /// ActionStatusType - Indicates the current disposition of the Action.
        /// </summary>
        [JsonProperty("actionStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ActionStatusType? ActionStatus { get; set; }

        private Thing agent;
        /// <summary>
        /// Person  or Organization - The direct performer or driver of the action (animate or inanimate). e.g. *John* wrote a book.
        /// </summary>
        [JsonProperty("agent")]
        public Thing Agent
        {
            get { return agent; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                agent = value;
            }
        }

        /// <summary>
        /// DateTime - The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), 
        /// the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. 
        /// John wrote a book from January to *December*. Note that Event uses startDate/endDate instead of startTime/endTime, 
        /// even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Thing - For failed actions, more information on the cause of the failure.
        /// </summary>
        [JsonProperty("error")]
        public Thing Error { get; set; }

        /// <summary>
        ///  Thing - The object that helped the agent perform the action. e.g. John wrote a book with *a pen*.
        /// </summary>
        [JsonProperty("instrument")]
        public Thing Instrument { get; set; }

        Thing location; 
        /// <summary>
        /// PostalAddress or Place - The location of the event, organization or action.
        /// </summary>
        [JsonProperty("location")]
        public Thing Location
        {
            get { return location; }
            set
            {
                var validator = new TypeValidator(typeof(PostalAddress), typeof(Place));
                validator.Validate(value);
                location = value;
            }
        }

        /// <summary>
        /// Thing - The object upon the action is carried out, whose state is kept intact or changed. Also known as the semantic roles patient, affected or undergoer (which change their state) or theme (which doesn't). e.g. John read *a book*.
        /// </summary>
        [JsonProperty("object")]
        public Thing ActionObject { get; set; }

        private Thing participant;

        /// <summary>
        /// Person  or  Organization - Other co-agents that participated in the action indirectly. e.g. John wrote a book with *Steve*.
        /// </summary>
        [JsonProperty("participant")]
        public Thing Participant
        {
            get { return participant; }
            set
            {
                var validator = new TypeValidator(typeof(Organization), typeof(Person));
                validator.Validate(value);
                participant = value;
            }
        }

        /// <summary>
        /// Thing - The result produced in the action. e.g. John wrote *a book*.
        /// </summary>
        [JsonProperty("result")]
        public Thing Result { get; set; }

        /// <summary>
        /// DateTime -The startTime of something. 
        /// For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. 
        /// For actions that span a period of time, when the action was performed. e.g. John wrote a book from *January* to December. 
        /// Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. 
        /// This situation may be clarified in future revisions.
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        /// <summary>
        ///EntryPoint - Indicates a target EntryPoint for an Action.
        /// </summary>
        [JsonProperty("target")]
        public MXTires.Microdata.Core.Intangible.EntryPoint Target { get; set; }
    }
}