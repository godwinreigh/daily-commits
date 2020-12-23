using System;

namespace Certain_Letter_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Sentence");

            string sentence1 = Console.ReadLine();

            int result = letterCount(sentence1);

            Console.WriteLine($"There are total of {result - 1} A alphabet(s) in your sentence");

            Console.ReadLine();
        }

        //static void method is a method that returns nothing
        //while other static like int or string, it will only allow return that certain primative data type

        static int letterCount(string sentence1)
        {
            int A_counter = sentence1.Split('a', 'A').Length;

            return A_counter;
        }
    }
}
