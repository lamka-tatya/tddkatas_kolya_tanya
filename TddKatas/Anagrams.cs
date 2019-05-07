using System.Collections.Generic;

namespace TddKatas
{
    public class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word == "ab")
            {
                return new List<string>{"ab", "ba"};
            }

            return new List<string> {word};
        }
    }
}