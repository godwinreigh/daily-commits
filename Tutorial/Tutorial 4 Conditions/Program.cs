using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {

            //Simple String to Int conversion
            /*
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("Your cash is insufficient");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Welcome to theater");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here's your ticket and your change: " + change + "$");
            }
            */

            //another program 

            /*
            // int is a value type
            int i = 0;
            // Prints True for any value of i
            bool check = i.GetType() == typeof(int);
            Console.WriteLine(check);

            //these works to not throw error when you put string instead of int or float
            Console.WriteLine("Please Enter a Number: ");
            try
            {
                int y = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid");
            }
            */

            //another program

            /*
            int age;
            int height;

            try
            {
                Console.WriteLine("What is your Age? ");

                age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Your Height? ");

                height = Convert.ToInt32(Console.ReadLine());

                //&& needs to be both statement is true to be executed
                //|| if one statement is true, code will be executed

                if (age > 15 && height > 20) //Checks if your height is above 20 and checks age above 15

                {
                    Console.WriteLine("You're Good");
                }

                else
                {
                    Console.WriteLine("You're Not Allowed Here");
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("Not a Number please try again");
            }
            */

            //another program
            try
            {
                Console.Write("Input a number between 1 and 5: ");
                int num = Convert.ToInt32(Console.ReadLine());
                //instead using a chain of if-else statements use switch
                switch (num)
                {
                    case 1: //underneath here we put what happens
                        Console.WriteLine("One");
                        break;

                    case 2:
                        Console.WriteLine("Two");
                        break;

                    case 3:
                        Console.WriteLine("Three");
                        break;

                    case 4:
                        Console.WriteLine("Four");
                        break;

                    case 5:
                        Console.WriteLine("Five");
                        break;

                    default: //if none if these are met
                        Console.WriteLine("None of the above");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("NaN");
            }







            Console.ReadKey();//Wait before close
        }
    }
}
