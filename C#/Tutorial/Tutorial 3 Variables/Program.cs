using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

             //4 primative data types
            //int (numbers), bool (true or false), string(""), float (decimal)

            //how to make variable
            //use var if you don't know what kind of data type you will use
            /*
            Console.WriteLine("Hello what's your name");

            string userName = Console.ReadLine();

            Console.WriteLine("Your Age?");

            string userAge = Console.ReadLine();

            Console.WriteLine(" Welcome " + userName + ".\n Nice to Meet You." + "\n Your age is "+userAge+ ".");
            */

            //doing basic math

            //declaring a variable
            double num01; //double can both store integers and floats;
            double num02;
            double num03;

            Console.Write("Input a number: ");

            num01 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a Second number: ");

            num02 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input a Third number: ");

            num03 = Convert.ToDouble(Console.ReadLine());

            double result = num01 + num02 + num03;

            Console.WriteLine("The result is: " + result / 3);
            
            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
