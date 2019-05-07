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
        private static char[] _oneLetterWords = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        
        [TestCaseSource(nameof(_oneLetterWords))]
        public void WhenPassed_OneLetter_Then_ShouldGenerate_CollectionWithSameLetter(char letter)
        {
            var word = letter.ToString();
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new[] {word});
        }

        [Test]
        public void WhenPassed_AB_Then_ShouldGenerate_AB_BA()
        {
            var word = "ab";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new []{"ab", "ba"});
        }
        
        [Test]
        public void WhenPassed_CD_Then_ShouldGenerate_CD_DC()
        {
            var word = "cd";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new []{"cd", "dc"});
        }
    }
}