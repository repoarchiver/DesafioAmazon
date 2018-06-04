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
    public class EightHousesCellsTests
    {
        private EightHousesCells eightHousesCells;
        public EightHousesCellsTests()
        {
            eightHousesCells = new EightHousesCells();
        }

        [TestMethod()]
        public void cellCompleteTest1()
        {
            int[] expectedCells = new[] { 0, 1, 0, 0, 1, 0, 1, 0 };
            int[] testCells = new[] { 1, 0, 0, 0, 0, 1, 0, 0 };
            int testeDay = 1;

            var cellsActual = eightHousesCells.cellComplete(testCells, testeDay);

            CollectionAssert.AreEqual(expectedCells, cellsActual);

        }

        [TestMethod()]
        public void cellCompleteTest2()
        {
            int[] expectedCells = new[] { 0, 0, 0, 0, 0, 1, 1, 0 };
            int[] testCells = new[] { 1, 1, 1, 0, 1, 1, 1, 1 };
            int testeDay = 2;

            var cellsActual = eightHousesCells.cellComplete(testCells, testeDay);

            CollectionAssert.AreEqual(expectedCells, cellsActual);

        }
    }
}