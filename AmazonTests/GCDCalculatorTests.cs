using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Tests
{
    [TestClass()]
    public class GCDCalculatorTests
    {
        private GCDCalculator GDC = new GCDCalculator();

        [TestMethod()]
        public void generalizedGCDTest1()
        {
            int expectedValue = 1;

            int num = 5;
            int[] arr = {2, 3, 4, 5, 6};

            var actualValue = GDC.generalizedGCD(num, arr);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void generalizedGCDTest2()
        {
            int expectedValue = 2;

            int num = 5;
            int[] arr = { 2, 4, 6, 8, 10 };

            var actualValue = GDC.generalizedGCD(num, arr);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod()]
        public void generalizedGCDTest3()
        {
            int expectedValue = 2;

            int num = 6;
            int[] arr = { 12, 14, 6, 8, 10, 2 };

            var actualValue = GDC.generalizedGCD(num, arr);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}