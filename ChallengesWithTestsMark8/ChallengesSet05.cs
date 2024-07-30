using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; ; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            int[] orderedNumbers = (int[])numbers.Clone();

            Array.Sort(orderedNumbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                if (orderedNumbers[i] != numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int postEvenCount = 0;
            bool addNext = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (addNext)
                {
                    postEvenCount += numbers[i];
                    addNext = false;
                }
                if (numbers[i] % 2 == 0)
                {
                    addNext = true;
                }
            }
            return postEvenCount;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }
            string sentance = string.Join(" ", words);

            sentance = Regex.Replace(sentance, @"\s+", " ").Trim();
            return sentance.Length > 0 ? $"{sentance}." : "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] emptyArray = { };
            if (elements == null || elements.Count == 0)
            {
                return emptyArray;
            }
            List<double> foursList = new List<double>();
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % 4 == 0)
                {
                    foursList.Add(elements[i]);
                }
            }
            return foursList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }
            HashSet<int> targetCheck = new HashSet<int>();

            foreach (int num in nums)
            {
                int digit = targetNumber - num;

                if (targetCheck.Contains(digit))
                {
                    return true;
                }
                targetCheck.Add(num);
            }
            return false;
        }
    }
}
