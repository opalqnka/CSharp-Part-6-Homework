/*Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Examples:

hexadecimal	   decimal
FE	            254
1AE3	        6883
4ED528CBB4	 338583669684
*/
using System;

namespace _15.HexToDec
{
    class Program
    {
        static void Main()
        {
            Console.Write("hex = ");
            string hex = Console.ReadLine();
            long number = 0;
            long result = 0;
            int lastIndex = hex.Length - 1;

            for (int i = 0; i < hex.Length; i++)
            {
                //Check the value of the current string element
                //if it has a letter - assign a value; if not - convert it to a long
                switch (hex[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                    default: 
                        number = long.Parse(hex[i].ToString());
                        break; 
                }
                //Add each single contribution to the final result
                //lastIndex - i reverses the order of the operation
                //instead to start from the first element now it starts from the last one
                result += number * (long)Math.Pow(16, lastIndex - i);
            }
            Console.WriteLine("Decimal = {0}", result);

        }
    }
}
