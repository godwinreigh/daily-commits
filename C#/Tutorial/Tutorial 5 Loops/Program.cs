using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //program that counts 1 to 10
            //before //condition //after
            for (int i = 0; i <= 10; i++)//you can also i-- to decrement
            {
                Console.WriteLine(i);
            }
            */


            /*
            //A program for pow
            try
            {
                Console.WriteLine("Please Enter the Number you want to be Pow: ");
                double input = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("How many times? ");
                int repeations = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j <= repeations; j++)
                {
                    //Math class - Has a bunch of mathematical functions that do all kinds of things
                    double result = Math.Pow(input, j);
                    Console.WriteLine("\n" + "The Power of " + input + " in " + j + ": " + result);
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid");
            }
            */

            //Program for while loops
            /*
            Random numberGen = new Random();//random number generator

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Please Enter to roll the dice");


            while (roll != 6)//while roll is not equal to six
            {
                Console.ReadKey();//Waits for the user to press key 

                roll = numberGen.Next(1, 7); //1 is inclusive //7 is exlusive
                Console.WriteLine("You rolled: " + roll);
                attempts++;//increase the value of attempts by one per loops
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a six");
            */

            //Program for two of a kind
            Random numberGen = new Random();//random number generator

            int roll = 0;
            int roll2 = 1;
            int attempts = 0;

            Console.WriteLine("Please Enter to roll the dice");


            while (roll != roll2)//while roll is not equal to six
            {
                Console.ReadKey();//Waits for the user to press key 

                roll = numberGen.Next(1, 7); //1 is inclusive //7 is exlusive
                roll2 = numberGen.Next(1, 7); //1 is inclusive //7 is exlusive

                Console.WriteLine("\n You rolled: " + roll);
                Console.WriteLine(" You rolled: " + roll2);

                attempts++;//increase the value of attempts by one per loops

                if (roll == roll2)
                {
                    Console.WriteLine("\nIt took you " + attempts + " attempts to roll two piece of a kind");
                }
                else
                {
                    Console.WriteLine(" Roll: " + attempts);
                }
            }





            Console.ReadKey();//It waits for the input of the user before it ending program
        }
    }
}
