using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionFun
{
    class RecursiveFunctionsFun
    {

        static void Main(string[] args)
        {
            Console.WriteLine("How many Fibonacci numbers to print?");
            long amount = int.Parse(Console.ReadLine());
            List<long> fibonacciNumbers = Fibonacci(amount);
            foreach (long fibonacciNumber in fibonacciNumbers)
            {
                Console.WriteLine(fibonacciNumber);
            }
            Console.ReadLine();
            //for (int m = 0; m < 3; m++)
            //{
            //    for (int n = 0; n < 1000; n++)
            //    {
            //        Console.WriteLine(string.Format("Ackerman({0},{1}) is: {2}", m, n, Ackermann(m, n)));
            //    }
            //}

        }

        /// <summary>
        /// WARNING. This method is HIGHLY RECURSIVE (see https://en.wikipedia.org/wiki/Ackermann_function). Use at your own risk. Do not use negative integers!!!
        /// </summary>
        /// <param name="m">A positive integer. Really starts to slow processing at 3 or above.</param>
        /// <param name="n">A positive integer. Not too dangerous is m is 2 or less.</param>
        /// <returns></returns>
        private static int Ackermann(int m, int n)
        {
            int ans;
            if (m == 0)
            {
                ans = n + 1;
            }
            else if (n == 0)
            {
                ans = Ackermann(m - 1, 1);
            }
            else
            {
                ans = Ackermann(m - 1, Ackermann(m, n - 1));
            }
            return ans;
        }
        /// <summary>
        /// Returns the Fibonacci numbers from the Fibonacci sequence starting from the beginning.
        /// </summary>
        /// <param name="amount">The Amount of Fibonacci numbers to return</param>
        /// <returns></returns>
        private static List<long> Fibonacci(long amount)
        {
            List<long> fibonacciNumbers = new List<long>(new long[] { 0, 1 });
            if (amount <= 0)
                return new List<long>();
            if (amount == 1)
                fibonacciNumbers.RemoveAt(1);
            else
            {
                for (long i = 2; i < amount; i++)
                {
                    fibonacciNumbers.Add(fibonacciNumbers.Last() + fibonacciNumbers[fibonacciNumbers.Count - 2]);
                }
            }
            return fibonacciNumbers;
        }
    }
}
