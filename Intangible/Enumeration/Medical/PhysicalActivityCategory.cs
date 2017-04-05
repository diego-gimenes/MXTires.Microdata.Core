﻿using System;
using System.Collections.Generic;
using System.Linq;
#region License
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

namespace MXTires.Microdata.Core.Intangible.Enumeration.Medical
{
    /// <summary>
    /// Categories of physical activity, organized by physiologic classification.
    /// </summary>
    [Flags]
    public enum PhysicalActivityCategory
    {
        /// <summary>
        /// Physical activity of relatively low intensity that depends primarily on the aerobic energy-generating process; during activity, the aerobic metabolism uses oxygen to adequately meet energy demands during exercise.
        /// </summary>
        AerobicActivity = 1 << 0,

        /// <summary>
        /// Physical activity that is of high-intensity which utilizes the anaerobic metabolism of the body.
        /// </summary>
        AnaerobicActivity = 1 << 1,

        /// <summary>
        /// Physical activity that is engaged to help maintain posture and balance.
        /// </summary>
        Balance = 1 << 2,

        /// <summary>
        /// Physical activity that is engaged in to improve joint and muscle flexibility.
        /// </summary>
        Flexibility = 1 << 3,

        /// <summary>
        /// Any physical activity engaged in for recreational purposes. Examples may include ballroom dancing, roller skating, canoeing, fishing, etc.
        /// </summary>
        LeisureTimeActivity = 1 << 4,

        /// <summary>
        /// Any physical activity engaged in for job-related purposes. Examples may include waiting tables, maid service, carrying a mailbag, picking fruits or vegetables, construction work, etc.
        /// </summary>
        OccupationalActivity = 1 << 5,

        /// <summary>
        /// Physical activity that is engaged in to improve muscle and bone strength. Also referred to as resistance training.
        /// </summary>
        StrengthTraining = 1 << 6,
    }
}
