using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MXTires.Microdata.Core.Validators;
using Newtonsoft.Json;

namespace MXTires.Microdata.Core.Actions.OrganizeActions
{
    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public class PlanAction : Action
    {
        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [JsonProperty("scheduledTime")]
        public DateTime? ScheduledTime
        {
            get;
            set;
        }
    }
}
