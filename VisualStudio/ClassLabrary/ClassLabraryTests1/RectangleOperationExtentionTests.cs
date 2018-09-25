using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLabrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabrary.Tests
{
    [TestClass()]
    public class RectangleOperationExtentionTests
    {
        [TestMethod()]
        public void Given_RectangleOperationExtention_width_5_height_5_when_ComputerArea_then_25()
        {
            int except = 25;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 5;
            int trueArea = RectangleOperationExtention.ComputerArea(input);
            Assert.AreEqual(except, trueArea);
        }
    }
}