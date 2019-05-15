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
        
        [Test]
        public void Return_3_For_3()
        {
            var number = 3;

            var result = PrimeFactors.Get(number);

            Assert.AreEqual(new[] {3}, result);
        }
    }

} 