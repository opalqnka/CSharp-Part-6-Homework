/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.
*/
using System;
using System.Threading;
using System.Globalization;

namespace _03.MinMaxAverage
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double minimal = 0.0d;
            double maximal = 0.0d;
            double sum = 0.0d;
            double average = 0.0d;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter number {0}: ", i);
                int number = int.Parse(Console.ReadLine());

                if (number >= maximal)
                {
                    maximal = number;
                }
                if (number <= minimal)
                {
                    minimal = number;
                }
                sum += number;
            }
            average = sum / (double)n;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\naverage = {3:F2}", minimal, maximal, sum, average);

                
        }
    }
}
