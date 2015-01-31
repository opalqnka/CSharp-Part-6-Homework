/*Problem 9. Matrix of Numbers

Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. 
Use two nested loops.
Examples:

n = 2  matrix      n = 3    matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
 */

using System;

namespace _09.MatrixOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(i + " ");

                    for (int j = 1; j < n; j++)
                    {
                        Console.Write((i + j) + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Please, try different input.");

        }
    }
}
