﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MXTires.Microdata.Core.Actions.InteractActions
{
    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates pushed to.
    /// Related actions:
    /// FollowAction: Unlike FollowAction, SubscribeAction implies that the subscriber acts as a passive agent being constantly/actively pushed for updates.
    /// RegisterAction: Unlike RegisterAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object.
    /// JoinAction: Unlike JoinAction, SubscribeAction implies that the agent is interested in continuing receiving updates from the object
    /// </summary>
    public class SubscribeAction : InteractAction
    {
    }
}
