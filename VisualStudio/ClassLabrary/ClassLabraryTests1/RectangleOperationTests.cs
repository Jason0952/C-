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
    public class RectangleOperationTests
    {
        [TestMethod()]
        public void Given_Rectangle_width_5_height_5_when_computerarea_then_25()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 5;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputerArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Rectangle_width_9_height_18_when_computerarea_then_25()
        {
            int expected = 162;
            Rectangle input = new Rectangle();
            input.width = 9;
            input.height = 18;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputerArea();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Given_Rectangle_width_0_height_0_when_computerarea_then_25()
        {
            int expected = 0;
            Rectangle input = new Rectangle();
            input.width = 0;
            input.height = 0;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputerArea();
            Assert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]
        public void Given_Rectangle_null_when_computerarea_then_NullReferenceException()
        {
            Rectangle input = null;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
            int actual = operation.ComputerArea();
        }
    }
}