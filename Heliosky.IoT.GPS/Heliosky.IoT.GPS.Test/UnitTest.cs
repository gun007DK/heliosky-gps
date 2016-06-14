﻿using System;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Heliosky.IoT.GPS;

namespace Heliosky.IoT.GPS.Test
{
    [TestClass]
    public class ParserLoadingTest
    {
        

        [TestMethod]
        public void LoadParserComponent()
        {
            var parser = new Model.NMEAParser();
        }

        [TestMethod]
        public void ParseGPGGAString()
        {
            string str = "$GPGGA,123519,4807.038,N,01131.000,E,1,08,0.9,545.4,M,46.9,M,,*47";
            var parser = new Model.NMEAParser();
            var res = parser.Parse(str);

            Model.FixData data = (Model.FixData)res;

        }
    }
}
