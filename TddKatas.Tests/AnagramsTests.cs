using NUnit.Framework;
using NUnit.Framework.Internal;
using TddKatas;

namespace Tests
{
    public class AnagramsTests
    {
        [Test]
        public void Test()
        {
            var word = "a";
            
            var result = Anagrams.Generate(word);

            CollectionAssert.AreEqual(result, new[] {"a"});
        }
    }
}