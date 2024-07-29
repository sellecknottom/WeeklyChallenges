using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                    Console.WriteLine($"Adding {numbers[i]}, total: {num}");
                }
                else
                {
                    num -= numbers[i];
                    Console.WriteLine($"Subtracting {numbers[i]}, total: {num}");
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int count1 = str1.Length;
            int count2 = str2.Length;
            int count3 = str3.Length;
            int count4 = str4.Length;

            int[] countArray = { count1, count2, count3, count4 };

            int smallestCount = countArray[0];

            for (int i = 0; i < countArray.Length; i++)
            {
                if (countArray[i] < smallestCount)
                {
                    smallestCount = countArray[i];
                }
            }
            return smallestCount;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] smallestNumArray = { number1, number2, number3, number4 };

            int smallestNum = smallestNumArray[0];

            for (int i = 0; i < smallestNumArray.Length; i++)
            {
                if (smallestNumArray[i] < smallestNum)
                {
                    smallestNum = smallestNumArray[i];
                }
            }
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);

        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int notNullCount = 0;

            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
                else
                {
                    notNullCount++;
                }
            }
            return (nullCount > notNullCount);
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            List<double> evensList = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evensList.Add(numbers[i]);
                }
            }
            if (evensList.Count == 0)
            {
                return 0;
            }
            double evensAverage = evensList.Average();
            return evensAverage;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number cannot be negative");
            }
            if (number == 0 || number == 1)
            {
                return 1;
            }

            int product = 1;

            for (int i = number; i > 0; i--)
            {
                product *= i;
            }
            return product;
        }
    }
}
