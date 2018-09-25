using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.shapeservice1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Shape;
using ClassLibrary1.shapeservice;

namespace ClassLibrary1.shapeservice1.Tests
{
    [TestClass()]
    public class CircleserviceTests
    {
        [TestMethod()]
        public void Given_RectangleService_width_3_height_3_when_ComputerArea1_then_9()
        {
            double except1 = 9;
            Rectangle input = new Rectangle();
            input.width = 3;
            input.height = 3;
            Rectangleservice rec = new Rectangleservice();
            rec.Target = input;
            double area = rec.ComputerArea1();
            Assert.AreEqual(except1, area);
        }

        [TestMethod()]
        public void Given_RectangleService_width_3_height_3_when_ComputerArea2_then_9()
        {
            double except2 = 12;
            Rectangle input = new Rectangle();
            input.width = 3;
            input.height = 3;
            Rectangleservice rec = new Rectangleservice();
            rec.Target = input;
            double total = rec.ComputerArea2();
            Assert.AreEqual(except2, total);
        }

        [TestMethod()]
        public void Given_CircleService_half_3_when_ComputerArea1_then_9()
        {
            double except1 = 9 * Math.PI;
            Circle input = new Circle();
            input.half = 3;
            Circleservice cir = new Circleservice();
            cir.Target = input;
            double total = cir.ComputerArea1();
            Assert.AreEqual(except1, total);
        }

        [TestMethod()]
        public void Given_CircleService_half_3_when_ComputerArea2_then_9()
        {
            double except2 = 6 * Math.PI;
            Circle input = new Circle();
            input.half = 3;
            Circleservice cir = new Circleservice();
            cir.Target = input;
            double total = cir.ComputerArea2();
            Assert.AreEqual(except2, total);
        }
    }
}