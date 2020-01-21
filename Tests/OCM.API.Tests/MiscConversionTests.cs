﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Memory;
using OCM.API.Common.Model;
using OCM.Core.Settings;
using Xunit;

namespace OCM.API.Tests
{
    /// <summary>
    /// Unit tests for misc conversions/utility methods
    /// </summary>
    public class MiscConversionTests
    {

        public MiscConversionTests()
        {

        }

        [Fact]
        public void CheckConversionOfConnectionInfoToSAELevels()
        {
            var conn = new ConnectionInfo
            {
                PowerKW = 1,
                Voltage = 120,
                Amps = 10
            };

            var level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 1, "Should be level 1");

            conn = new ConnectionInfo
            {
                PowerKW = 3,
                Voltage = 230
            };

            level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 2, "Should be level 2");


            conn = new ConnectionInfo
            {
                PowerKW = 14,
                CurrentTypeID = (int)StandardCurrentTypes.ThreePhaseAC,
                Voltage = 400
            };

            level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 2, "Should be level 2");

            conn = new ConnectionInfo
            {
                Amps = 32, 
                PowerKW = 22,
                CurrentTypeID = (int)StandardCurrentTypes.ThreePhaseAC,
                Voltage = 400
            };

            level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 2, "Should be level 2");

            conn = new ConnectionInfo
            {
                Amps = 63, 
                PowerKW = 43,
                CurrentTypeID = (int)StandardCurrentTypes.ThreePhaseAC,
                Voltage = 400
            };

            level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 3, "Should be level 3");

            conn = new ConnectionInfo
            {
                PowerKW = 50,
                CurrentTypeID = (int)StandardCurrentTypes.DC,
                Voltage = 400
            };

            level = Common.Model.Extensions.ConnectionInfo.ComputeChargingLevel(conn);
            Assert.True(level == 3, "Should be level 3");
        }

    }
}
