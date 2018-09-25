using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Shape;

namespace ClassLibrary1.Helper.Tests
{
    [TestClass()]
    public class ShaperHelperTests
    {
        [TestMethod()]
        public void Given1()
        {
            int except = 50;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 10;
            double operation = ShaperHelper.ComputerArea1(input);
            Assert.AreEqual(except,operation);
        }

        [TestMethod()]
        public void Given2()
        {
            int except = 30;
            Rectangle input = new Rectangle();
            input.width = 5;
            input.height = 10;
            double operation = ShaperHelper.ComputerArea2(input);
            Assert.AreEqual(except, operation);
        }

        [TestMethod()]
        public void Given3()
        {
            double except = 25 * Math.PI;
            Circle input = new Circle();
            input.half = 5;
            double operation = ShaperHelper.ComputerArea1(input);
            Assert.AreEqual(except, operation);
        }

        [TestMethod()]
        public void Given4()
        {
            double except = 10 * Math.PI;
            Circle input = new Circle();
            input.half = 5;
            double operation = ShaperHelper.ComputerArea2(input);
            Assert.AreEqual(except, operation);
        }
    }
}