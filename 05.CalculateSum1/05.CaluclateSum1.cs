/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
 */
using System;
using System.Threading;
using System.Globalization;

namespace _05.CalculateSum1
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());

            double sum = 1.0;
            double term = 1.0;

            for (int i = 1; i <= n; i++)
            {
                term *= (double)i / x;
                sum = sum + term;  
            }

            Console.WriteLine("S = {0:F5}", sum);

        }
    }
}
