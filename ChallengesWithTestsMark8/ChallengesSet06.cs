using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (string logos in words)
            {
                if (logos == null)
                {
                    continue;
                }
                bool match = ignoreCase
            ? string.Equals(logos, word, StringComparison.OrdinalIgnoreCase)
            : string.Equals(logos, word, StringComparison.Ordinal);

                if (match)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return -1;
            }
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char uniqueChar in str)
            {
                if (charCount.ContainsKey(uniqueChar))
                {
                    charCount[uniqueChar]++;
                }
                else
                {
                    charCount[uniqueChar] = 1;
                }
            }
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charCount[str[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxCount = 1;
            int currentCount = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                    currentCount = 1;
                }
            }
            if (currentCount > maxCount)
            {
                maxCount = currentCount;
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] emptyArray = { };
            if (elements == null || elements.Count == 0)
            {
                return emptyArray;
            }
            if (n < 0)
            {
                return emptyArray;
            }

            List<double> nthList = new List<double>();

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    nthList.Add(elements[i]);
                }
            }
            return nthList.ToArray();
        }
    }
}
