using System.Collections.Generic;
using NUnit.Framework;
using TddKatas;

namespace Tests
{
    public class CombinedNumberShould
    {
        [Test]
        public void GenerateSameString_WhenPassed_1()
        {
            var numList = new List<int> {1};

            var result = CombinedNumber.GenerateLargest(numList);

            Assert.AreEqual("1", result);
        }
    }
}