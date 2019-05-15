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
        
        [Test]
        public void Return_2_5_For_10()
        {
            var number = 10;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {2, 5}, result);
        }
        
        [Test]
        public void Return_5_5_For_25()
        {
            var number = 25;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {5, 5}, result);
        }
        
        [Test]
        public void Return_2_2_2_For_8()
        {
            var number = 8;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {2, 2, 2}, result);
        }
        
        [Test]
        public void Return_2_2_3_For_12()
        {
            var number = 12;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {2, 2, 3}, result);
        }
        
        [Test]
        public void Return_3_3_3_For_27()
        {
            var number = 27;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {3, 3, 3}, result);
        }
        
        [Test]
        public void Return_7_7_For_49()
        {
            var number = 49;

            var result = PrimeFactors.Get(number);

            CollectionAssert.AreEquivalent(new[] {7, 7}, result);
        }
    }

} 