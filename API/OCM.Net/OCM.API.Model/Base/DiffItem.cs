﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCM.API.Common.Model
{

    /// <summary>
    /// Used to prepare list of differences between two objects
    /// </summary>
    public class DiffItem
    {
        public string DisplayName { get; set; }
        public string Context { get; set; }
        public string ValueA { get; set; }
        public string ValueB { get; set; }
    }

}
