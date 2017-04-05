using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MXTires.Microdata.Core.Actions.OrganizeActions;

using Newtonsoft.Json;

namespace MXTires.Microdata.Core.Actions.InteractActions.CommunicateActions
{
    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected.
    /// Related actions:
    /// <see cref="CancelAction"/>: The antonym of ConfirmAction
    /// </summary>
    public class ConfirmAction : InformAction 
    {
    }
}
