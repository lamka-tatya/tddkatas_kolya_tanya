using System.Collections.Generic;

namespace TddKatas
{
    public class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word == "b")
            {
                return new List<string> {"b"};
            }
            return new List<string> {"a"};
        }
    }
}