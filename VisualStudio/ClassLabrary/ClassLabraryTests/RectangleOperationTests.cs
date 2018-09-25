using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLabrary.Rectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLabrary.Rectangle.Tests
{
    [TestClass()]
    public class RectangleOperationTests
    {
        [TestMethod()]
        public void Given_Rectangle_width_5_height_5_when_computerarea1_then_25()
        {
            int expected = 25;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 5;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
        }

        [TestMethod()]
        public void Given_Rectangle_width_5_height_5_when_computerarea2_then_25()
        {
            double expected = 20;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 5;
            RectangleOperation operation = new RectangleOperation();
            operation.Target = input;
        }
    }
}