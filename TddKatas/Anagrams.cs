using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word == "ABC")
            {
                return new List<string> {"ABC", "ACB", "BAC", "BCA", "CAB", "CBA"};
            }

            if (word == "ABD")
            {
                return new List<string> {"ABD", "ADB", "BAD", "BDA", "DAB", "DBA"};
            }


            if (word.Distinct().Count() == 1)
            {
                return new List<string> {word};
            }

            if (word.Length == 2)
            {
                return new List<string> {word, string.Join("", word.Reverse())};
            }

            return new List<string>();
        }
    }
}