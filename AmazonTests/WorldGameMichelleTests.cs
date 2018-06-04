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
    public class WorldGameMichelleTests
    {
        private WorldGameMichelle worldGameMichelle = new WorldGameMichelle();
        [TestMethod()]
        public void subStringsKDistTest()
        {
            string inputString = "awaglknagawunagwkwagl";
            int num = 4;

            List<string> substringExpected = new List<string>()
            {
                "wagl", "aglk", "glkn", "lkna", "knag", "gawu", "awun", "wuna", "unag", "nagw", "agwk", "kwag"
            };

            List<string> substringActual = worldGameMichelle.subStringsKDist(inputString, num);

            CollectionAssert.AreEqual(substringExpected, substringActual);
        }
    }
}