using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            //do loop
            //do loops checks for the conditon first before looping
            int isTrue = 1;
            do
            {
                Console.WriteLine($"Itteration {isTrue}");
                isTrue++;
            } while (isTrue != 6);
            //A program that checks if the number is divisible by 3 in range
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} is Divisible by 3");
                }
                else
                {
                    Console.WriteLine($"{i} is not Divisible by 3");
                }
            }
            Console.ReadKey();
        }
    }
}
