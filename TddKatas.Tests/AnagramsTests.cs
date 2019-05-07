using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        [TestCaseSource(nameof(_oneLetterWords))]
        public void WhenPassed_OneLetter_Then_ShouldGenerate_CollectionWithSameLetter(char letter)
        {
            var word = letter.ToString();
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new[] {word});
        }

        static char[] _oneLetterWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    }
}