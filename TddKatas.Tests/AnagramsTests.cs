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