﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GraphicalProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicalProgrammingLanguage.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void setParameterTest()
        {
            var l = new Triangle();
            int x = 200, y = 200, toX = 200, toY = 200;
            l.set(x, y, toX, toY);
            Assert.AreEqual(200, l.x);
        }
    }
}