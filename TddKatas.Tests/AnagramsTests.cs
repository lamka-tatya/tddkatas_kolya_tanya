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
        
        [Test]
        public void WhenPassed_ER_Then_ShouldGenerate_ER_RE()
        {
            var word = "er";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new []{"er", "re"});
        }
        
        [Test]
        public void WhenPassed_EE_Then_ShouldGenerate_EE()
        {
            var word = "ee";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new []{"ee"});
        }
        
        [Test]
        public void WhenPassed_FF_Then_ShouldGenerate_FF()
        {
            var word = "ff";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new []{"ff"});
        }
        
        [Test]
        public void WhenPassed_EmptyString_Then_ShouldGenerate_EmptyCollection()
        {
            var word = "";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new string[0]);
        }
        
        [Test]
        public void WhenPassed_ABC_Then_ShouldGenerate_ABC_ACB_BAC_BCA_CAB_CBA()
        {
            var word = "ABC";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new string[]{"ABC","ACB","BAC","BCA","CAB","CBA"});
        }
        
        [Test]
        public void WhenPassed_ABDThen_ShouldGenerate_ABD_ADB_BAD_BDA_DAB_DBA()
        {
            var word = "ABD";
            
            var result = Anagrams.Generate(word);
            
            CollectionAssert.AreEqual(result, new string[]{"ABD","ADB","BAD","BDA","DAB","DBA"});
        }
    }
}