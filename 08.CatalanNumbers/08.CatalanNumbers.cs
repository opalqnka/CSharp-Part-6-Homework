/*Problem 8. Catalan Numbers

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
https://github.com/TelerikAcademy/CSharp-Part-1/blob/master/6.%20Loops/README.md#problem-8--catalan-numbers
 */
using System;
using System.Numerics;

namespace _08.CatalanNumbers
{
    class Program
    {
        //I define a function Factoriel, makes the job easy to do
        static public BigInteger Factoriel(int n)
        {
            BigInteger result;
            if (n == 1 || n == 0)
                result = 1;
            else
                result = (n * Factoriel(n - 1));
            return result;
        }

        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1)
            {
                BigInteger result;
                result = Factoriel(2 * n) / ( Factoriel(n + 1) * Factoriel(n) );

                Console.WriteLine("The result is: {0}", result);
            }
            else
                Console.WriteLine("Try different input.");
        }
    }
}
