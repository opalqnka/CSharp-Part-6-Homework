/*Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: formula For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */

using System;
using System.Numerics;

namespace _07.CalculateCombinations
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            if (n < 100 && n > k && k > 1)
            {
                //Use the properties of factoriel to simplify the expression n!/k!
                //As n > k we have: [ n.(n-1)...(k).(k-1)...1 ] / [k.(k-1)...1] <=> n.(n-1)...(k+1)
                for (int i = (k + 1); i <= n; i++)
                {
                    result = result * i;
                }
                //Divide the above result by (n-k)!
                for (int j = 1; j <= (n - k); j++)
                {
                    result = result / j;
                }
                Console.WriteLine("Result: {0}", result);
            }
            else
                Console.WriteLine("Try different input");

        }
    }
}
