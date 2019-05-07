using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TddKatas;

namespace Tests
{
    public class AnagramsTests
    {
        [Test]
        public void WhenPassed_Word_A_Then_ShouldGenerate_CollectionWithSingle_Word_A()
        {
            var word = "a";
            
            var result = Anagrams.Generate(word);

            CollectionAssert.AreEqual(result, new[] {"a"});
        }

        [Test]
        public void WhenPassed_Word_B_Then_ShouldGenerate_CollectionWithSingle_Word_B()
        {
            var word = "b";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new[] {"b"});
        }
        
    }
}