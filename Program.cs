using System;
using static System.Console;

namespace Test
{
    class Program
    {

        static void PrimeNumbers(int num)
        {
            int[] primeNumbers = new int[num];
            int arrayCount = 1;
            int count = 0;
            int number = 0;

            primeNumbers[0] = 1;

            for (int i = 2; i <= num; i++)
            {
                if (count == 1)
                {
                    primeNumbers[arrayCount] = number;
                    arrayCount++;
                }

                count = 0;

                for (int j = 2; j <= num; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        number = i;
                    }
                }
            }

            int[] definitivePrimeNumbers = new int[arrayCount];

            for (int i = 0; i < arrayCount; i++)
            {
                definitivePrimeNumbers[i] = primeNumbers[i];
            }

            for (int x = 0; x < definitivePrimeNumbers.Length; x ++)
            {
                Write($"{definitivePrimeNumbers[x]}");
                if (x != definitivePrimeNumbers.Length - 1)
                {
                    Write(", ");
                }
            }
        }

        // static int PrimeFactor(int num)
        // {
        //     if (num == 1 || num == 2 || num == 3 || num == 5)
        //     {
        //         return num;
        //     }
        //     else if (num % 2 == 0)
        //     {
        //         return 2;
        //     }
        //     else if (num % 3 == 0)
        //     {
        //         return 3;
        //     }
        //     else if (num % 5 == 0)
        //     {
        //         return 5;
        //     }
        //     else
        //     {
        //         return num;
        //     }
        // }

        // static void RunPrimeFactor()
        // {
        //     int count = 0;
        //     Write("Enter a number: ");
        //     string number = ReadLine();

        //     try
        //     {
        //         count = int.Parse(number);
        //     }
        //     catch (FormatException)
        //     {
        //         WriteLine("You have to enter a valid number!");
        //     }

        //     if (count > 0) {
        //     Write($"Prime factors of {number} are: ");
        //     }

        //     if (count == 1)
        //     {
        //         Write(number);
        //     }

        //     while (count > 1)
        //     {
        //         int prime = PrimeFactor(count);
        //         count /= prime;
        //         if (count > 1)
        //         {
        //             Write($"{prime} x ");
        //         }
        //         else
        //         {
        //             Write($"{prime} ");
        //         }
        //     }
        // }

        static void Main(string[] args)
        {
            // RunPrimeFactor();

            Write("Enter a range: ");
            string range = ReadLine();
            PrimeNumbers(int.Parse(range));
        }
    }
}
