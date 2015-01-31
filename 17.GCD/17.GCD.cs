/*Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
Examples:

a	b	GCD(a, b)
3	2	1
60	40	20
5	-15	5
*/
using System;


namespace _17.GCD
{
    class Program
    {
        //solve the problem recursively
        public static int GCD(int A, int B)
        {
            int a = Math.Abs(A);
            int b = Math.Abs(B);

            if (a == 0)
                return Math.Abs(b);
            if (b == 0)
                return Math.Abs(a);

            if (a > b)
                return GCD(a % b, b);
            else
                return GCD(a, b % a);
        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The GCD of a = {0} and b = {1} is GCD(a, b) = {2}", a, b, GCD(a, b));
        }
    }
}
