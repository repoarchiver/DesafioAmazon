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
    public class CalculateTripTests
    {
        private class TesteTrips
        {
            public TesteTrips(int result, int tripMaxWeight, int[] packagesWeight)
            {
                Result = result;
                TripMaxWeight = tripMaxWeight;
                PackagesWeight = packagesWeight;
            }

            public int Result;
            public int TripMaxWeight;
            public int[] PackagesWeight;
        }

        [TestMethod()]
        public void minimumNumberOfTripsTest()
        {
            CalculateTrip calculateTrip = new CalculateTrip();

            List<TesteTrips> testList = new List<TesteTrips>();

            testList.Add(new TesteTrips(2, 100, new int[] { 70, 30, 20 }));
            testList.Add(new TesteTrips(3, 100, new int[] { 70, 70, 60 }));
            testList.Add(new TesteTrips(1, 100, new int[] { 30, 20 }));
            testList.Add(new TesteTrips(2, 100, new int[] { 70, 30, 20, 20 }));
            testList.Add(new TesteTrips(1, 100, new int[] { 70 }));
            testList.Add(new TesteTrips(1, 100, new int[] { 70, 20 }));
            testList.Add(new TesteTrips(2, 100, new int[] { 70, 31 }));
            testList.Add(new TesteTrips(3, 100, new int[] { 70, 31, 70 }));

            foreach (var itemTest in testList)
            {
                Assert.AreEqual(itemTest.Result, calculateTrip.minimumNumberOfTrips(itemTest.TripMaxWeight, itemTest.PackagesWeight));
            }
        }
    }
}