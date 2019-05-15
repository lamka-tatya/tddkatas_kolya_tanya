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
        
        [Test]
        public void Return_5_For_5()
        {
            var number = 5;

            var result = PrimeFactors.Get(number);

            Assert.AreEqual(new[] {5}, result);
        }
        
        [Test]
        public void Return_2_2_For_4()
        {
            var number = 4;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEqual(new[] {2, 2}, result);
        }
        
        [Test]
        public void Return_2_3_For_6()
        {
            var number = 6;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {2, 3}, result);
        }
        
        [Test]
        public void Return_3_3_For_9()
        {
            var number = 9;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {3, 3}, result);
        }
    }

} 