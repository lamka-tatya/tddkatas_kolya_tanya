using NUnit.Framework;
using TddKatas;

namespace Tests
{
    public class PrimeFactorsShould
    {
        [Test]
        public void Return_2_For_2()
        {
            var number = 2;

            var result = PrimeFactors.Get(number);

            Assert.AreEqual(new[] {2}, result);
        }
    }

} 