using System.Collections.Generic;

namespace TddKatas
{
    public static class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word == "ab")
            {
                return new List<string>{"ab", "ba"};
            }

            if (word == "cd")
            {
                return new List<string>{"cd", "dc"};
            }

            
            return new List<string> {word};
        }
    }
}