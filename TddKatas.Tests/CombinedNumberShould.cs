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

        [Test]
        public void GenerateSameString_WhenPassed_10()
        {
            var numList = new List<int> {10};

            var result = CombinedNumber.GenerateLargest(numList);

            Assert.AreEqual("10", result);
        }

        [Test]
        public void GenerateString20_WhenPassed_0_and_2()
        {
            List<int> numList = new List<int> {0, 2};

            var result = CombinedNumber.GenerateLargest(numList);

            Assert.AreEqual("20", result);
        }
    }
}