using System;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            ChallengesSet04 challenger = new ChallengesSet04();

            int[] numbers1 = { 2, 6, 8, 3, 1, 3 };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers1)}");

            int[] numbers2 = { 4, 6, 10 };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers2)}");

            int[] numbers3 = { 3, 1, 3 };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers3)}");

            int[] numbers4 = { 2, 3 };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers4)}");

            int[] numbers5 = { 0, 0 };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers5)}");

            int[] numbers6 = { };
            Console.WriteLine($"Result: {challenger.AddEvenSubtractOdd(numbers6)}");
        }
    }
}
