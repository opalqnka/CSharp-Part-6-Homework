/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
*/

using System;


namespace _10.OddAndEvenProduct
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter n integers:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            int evenNum = 1;
            int oddNum = 1;


            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (i % 2 != 0)
                {
                    evenNum *= int.Parse(numbers[i]);
                }
                else
                    oddNum *= int.Parse(numbers[i]);
            }
            if (evenNum == oddNum)
            {
                Console.WriteLine("Equal. The product is: {0}", evenNum);
            }
            else
            {
                Console.WriteLine("Not equal.\nEven product = {0}\nOdd product = {1}", evenNum, oddNum);
            }

        }
    }
}
