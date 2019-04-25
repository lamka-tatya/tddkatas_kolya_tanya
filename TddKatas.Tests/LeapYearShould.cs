using NUnit.Framework;
using TddKatas;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Identify_1996_AsLeap_BecauseDividedBy4()
        {
            var year = 1996;
            
            var result = LeapYear.Check(year);
            
            Assert.IsTrue(result);
        }

        [Test]
        public void Identify_2001_AsCommon()
        {
            var year = 2001;
            
            var result = LeapYear.Check(year);
            
            Assert.IsFalse(result);
        }
        
        [Test]
        public void Identify_2002_AsCommon()
        {
            var year = 2002;
            
            var result = LeapYear.Check(year);
            
            Assert.IsFalse(result);
        }
        
        [Test]
        public void Identify_2000_AsLeap_BecauseDividedBy400()
        {
            var year = 2000;
            
            var result = LeapYear.Check(year);
            
            Assert.IsTrue(result);
        }
        
        [Test]
        public void Identify_1900_AsCommon_BecauseDividedBy100()
        {
            var year = 1900;
            
            var result = LeapYear.Check(year);
            
            Assert.IsFalse(result);
        }
    }
}