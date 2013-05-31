﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OCM.API.Common.Model
{
    public class UsageType : SimpleReferenceDataType
    {
        public bool? IsPayAtLocation { get; set; }
        public bool? IsMembershipRequired { get; set; }
        public bool? IsAccessKeyRequired { get; set; }
    }
}