/*Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
 */
using System;


namespace _06.CalculateNK
{
    class Program
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int result = 1;

            if (n < 100 && n > k && k > 1)
            {
                //Use the properties of factoriel to simplify the expression n!/k!
                //As n > k we have: [ n.(n-1)...(k).(k-1)...1 ] / [k.(k-1)...1] <=> n.(n-1)...(k+1)
                for (int i = (k + 1); i <= n; i++)
                {
                    result = result * i;
                }
                Console.WriteLine("Result: {0}", result);
            }
            else
                Console.WriteLine("Try different input");
        }
    }
}
