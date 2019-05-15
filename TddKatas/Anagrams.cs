using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return new List<string>();
            }

            if (word.Length == 1)
            {
                return new List<string> {word};
            }
            
            return GetAnagrams(word).Distinct().ToList();
        }

        private static List<string> GetAnagrams(string word)
        {
            if (word.Length == 2)
            {
                return new List<string> {word, string.Join("", word.Reverse())};
            }

            var firstLetter = word[0].ToString();
            word = word.Substring(1);

            var result = new List<string>();

            foreach (var anagram in GetAnagrams(word))
            {
                for (int i = 0; i <= word.Length; i++)
                {
                    result.Add(anagram.Insert(i, firstLetter));
                }
            }

            return result;
        }
    }
}