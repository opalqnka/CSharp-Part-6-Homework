/*Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Examples:

binary	                      decimal
0	                            0
11	                            3
1010101010101011	            43691
1110000110000101100101000000	236476736
*/

using System;

namespace _13.BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter a binary number: ");
            string numberBi = Console.ReadLine();
            long numberDec = 0;

            for (int i = 0; i < numberBi.Length; i++)
            {
                if (numberBi[i] == '0')
                {
                    continue;
                }
                numberDec += (long)Math.Pow(2, i);
            }
            Console.WriteLine("The decimal representation of the binary number {0} is: {1}", numberBi, numberDec);
        }
    }
}
