/*Problem 16. Decimal to Hexadecimal Number

Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	       hexadecimal
254	                 FE
6883	           1AE3
338583669684	4ED528CBB4
*/

using System;

namespace _16.DecimalToHex
{
    class Program
    {
        static void Main()
        {
            Console.Write("Decimal = ");
            long number = long.Parse(Console.ReadLine());
            long digit = 0;
            string numStr = number.ToString();
            string result = "";

            for (int i = 0; i < numStr.Length; i++)
            {
                digit = number % 16;
                number = number / 16;

                //There are no 0s in hex, due to the chosen method I need to exclude any 0s
                if (digit == 0)
                {
                    continue;
                }

                switch (digit)
                {
                    case 10: result += "A"; break;
                    case 11: result += "B"; break;
                    case 12: result += "C"; break;
                    case 13: result += "D"; break;
                    case 14: result += "E"; break;
                    case 15: result += "F"; break;
                    default:
                        result += digit;
                        break;
                }
            }
            string reverse = "";
            for (int i = result.Length - 1; i >= 0; i--)
            {
                reverse += result[i];
            }
          Console.WriteLine("Hex = {0}", reverse);
        }
    }
}
