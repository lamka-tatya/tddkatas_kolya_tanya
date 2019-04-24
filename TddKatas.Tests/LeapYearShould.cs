using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Define_1996_AsLeap()
        {
            var year = 1996;
            
            var result = LeapYear.Check(year);
            
            Assert.IsTrue(result);;
        }
    }

    public static class LeapYear
    {
        public static bool? Check(int year)
        {
            throw new System.NotImplementedException();
        }
    }
}