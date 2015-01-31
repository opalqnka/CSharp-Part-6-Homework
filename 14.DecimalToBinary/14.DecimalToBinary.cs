/*Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.

Examples:

decimal	             binary
0	                   0
3	                   11
43691	        1010101010101011
236476736	 1110000110000101100101000000
*/

using System;

namespace _14.DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            Console.Write("decimal = ");
            long dec = long.Parse(Console.ReadLine());
            string result = "";

            if (dec == 0)
            {
                Console.WriteLine("Binary = 0");
            }

            else
            {
                while (dec >= 1)
                {
                    result = result + (dec % 2);
                    dec = dec / 2;
                }
                Console.WriteLine("Binary = {0}", result);
            }

        }
    }
}
