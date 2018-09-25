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
    public class RectangleOperationHelperTests
    {
        [TestMethod()]
        public void Given_RectangleOperationHelper_width_5_height_5_when_computer_then_25()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 5;
            int actual = RectangleOperationHelper.Computer(input);
            Assert.AreEqual(expected, actual);
        }
    }
}