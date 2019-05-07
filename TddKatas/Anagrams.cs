using System.Collections.Generic;
using System.Linq;

namespace TddKatas
{
    public static class Anagrams
    {
        public static List<string> Generate(string word)
        {
            if (word.Distinct().Count() == 1)
            {
                return new List<string> {word};
            }

            if (word.Length == 4)
            {
                var firstLetter = word[0].ToString();
                word = word.Substring(1);
                var result = new List<string>();

                foreach (var anagram in GetAnagramsForThreeLetters(word))
                {
                    result.Add(anagram.Insert(0, firstLetter));
                    result.Add(anagram.Insert(1, firstLetter));
                    result.Add(anagram.Insert(2, firstLetter));
                    result.Add(anagram.Insert(3, firstLetter));
                }

                return result;
            }

            if (word.Length == 3)
            {
                return GetAnagramsForThreeLetters(word);
            }

            if (word.Length == 2)
            {
                return GetAnagramsFromTwoLetters(word);
            }

            return new List<string>();
        }

        private static List<string> GetAnagramsForThreeLetters(string word)
        {
            var firstLetter = word[0].ToString();
            word = word.Substring(1);
            var result = new List<string>();

            foreach (var anagram in GetAnagramsFromTwoLetters(word))
            {
                result.Add(anagram.Insert(0, firstLetter));
                result.Add(anagram.Insert(1, firstLetter));
                result.Add(anagram.Insert(2, firstLetter));
            }

            return result;
        }

        private static List<string> GetAnagramsFromTwoLetters(string word)
        {
            return new List<string> {word, string.Join("", word.Reverse())};
        }
    }
}