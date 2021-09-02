using System;

namespace Homework_4
{
    /// <summary>
    /// Homework 4.
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            int quantityOfEven = 0;
            int quantityOfOdd = 0;

            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(1, 27);
                if (array[i] % 2 == 0)
                {
                    quantityOfEven++;
                }
                else
                {
                    quantityOfOdd++;
                }
            }

            char[] evenArray = new char[quantityOfEven];
            char[] oddArray = new char[quantityOfOdd];

            int quantityOfToUpperEven = 0;
            int quantityOfToUpperOdd = 0;

            for (int i = 0; i < quantityOfEven; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[j] % 2 == 0)
                    {
                        char tempChar = (char)(array[j] + 96);
                        if (tempChar == 'a' || tempChar == 'e' || tempChar == 'i' || tempChar == 'd' || tempChar == 'h' || tempChar == 'j')
                        {
                            string tempString = tempChar.ToString().ToUpper();
                            evenArray[i] = Convert.ToChar(tempString);
                            quantityOfToUpperEven++;
                        }
                        else
                        {
                            evenArray[i] = tempChar;
                        }

                        i++;
                    }
                }
            }

            for (int i = 0; i < quantityOfOdd; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[j] % 2 != 0)
                    {
                        char tempChar = (char)(array[j] + 96);
                        if (tempChar == 'a' || tempChar == 'e' || tempChar == 'i' || tempChar == 'd' || tempChar == 'h' || tempChar == 'j')
                        {
                            string tempString = tempChar.ToString().ToUpper();
                            oddArray[i] = Convert.ToChar(tempString);
                            quantityOfToUpperOdd++;
                        }
                        else
                        {
                            oddArray[i] = tempChar;
                        }

                        i++;
                    }
                }
            }

            QuantityOfToUpper(quantityOfToUpperEven, quantityOfToUpperOdd);

            Console.WriteLine("First array:");
            for (int i = 0; i < quantityOfEven; i++)
            {
                Console.Write(evenArray[i] + " ");
                if (i == quantityOfEven - 1)
                {
                    Console.Write(evenArray[i] + "\n");
                }
            }

            Console.WriteLine("Second array:");
            for (int i = 0; i < quantityOfOdd; i++)
            {
                Console.Write(oddArray[i] + " ");
                if (i == quantityOfOdd - 1)
                {
                    Console.Write(oddArray[i] + "\n");
                }
            }
        }

        private static void QuantityOfToUpper(int even, int odd)
        {
            if (even > odd)
            {
                Console.WriteLine($"The first array of even numbers has more uppercase letters: [{even} > {odd}]");
            }
            else if (even < odd)
            {
                Console.WriteLine($"The second array of odd numbers has more uppercase letters: [{odd} > {even}]");
            }
            else
            {
                Console.WriteLine($"Two arrays have the same number of uppercase letters: [{even} = {odd}]");
            }
        }
    }
}
