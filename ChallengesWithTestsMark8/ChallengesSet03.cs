using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Any(val => val == false);
            /*foreach (var val in vals)
            {

                if (val == false)
                {
                    return true;
                }
            }
            return false;*/
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }

            int sumOfOdds = numbers.Where(n => n % 2 != 0).Sum();

            return sumOfOdds % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            char[] passwordChars = password.ToCharArray();
            foreach (char c in passwordChars)
            {
                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }
                else if (char.IsLower(c))
                {
                    hasLower = true;
                }
                else if (char.IsDigit(c))
                {
                    hasNumber = true; 
                }
            }
            if (hasUpper && hasLower && hasNumber)
            {
                return true;
            }
            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0]; 
        }

        public char GetLastLetterOfString(string val)
        {
            return val[(int)val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int [] odds = new int[50];
            int numIndex = 0;
            for (int i = 1; i < 100; i += 2) 
            {
                odds[numIndex] = i;
                numIndex++;
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
