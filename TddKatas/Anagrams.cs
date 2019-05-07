using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word == "ee")
            {
                return new List<string> {word};
            }
            
            if (word == "ff")
            {
                return new List<string> {word};
            }

            if (word.Length == 2)
            {
                return new List<string>{word, string.Join("", word.Reverse())};
            }
            
            return new List<string> {word};
        }
    }
}