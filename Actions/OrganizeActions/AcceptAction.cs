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
    /// The act of committing to/adopting an object.
    /// Related actions:
    /// <see cref="RejectAction"/>: The antonym of AcceptAction
    /// </summary>
    public class AcceptAction : AllocateAction
    {
    }
}
