//NOTES\\
//Using Methods we can reuse a code
//A method, allows us to group together code that performs a specific task.
//This way we can only write the code once, and only use to when it only needs.
//You can only create Method outside of the main
//You can only call the Method inside of the main

//HOW TO USE A METHOD\\

//First we define the method
//Then we call it

using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Basic Calling function\\

            MeetAlien();
            Console.WriteLine("---------");
            MeetAlien();//you can do this many times effortlessly
            */



            //A program if the number is Even or Uneven\\

            //get input
            try
            {
                Console.WriteLine("Multiply a Number");
                Console.WriteLine("Please Enter the First Number");
                int input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter the Second Number");
                int input2 = Convert.ToInt32(Console.ReadLine());
                int answer = primeChecker(input1, input2);//using return statement you can get the value of the function
                Console.WriteLine("= " + answer);

                //% = is an operator that gets the reminder of decimal
                //answer / 2 , then get the remainder.

                if (answer % 2 == 0)//if the remainder of the division is 0 then do this
                {
                    Console.WriteLine("Your answer is even number that has a result of " + answer / 2);
                }
                else
                {
                    int realAns = answer / 2;
                    int remainder = answer % 2;
                    Console.WriteLine("The result is " + realAns + " that has remainder of " + remainder + " which is uneven number");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Try Again");
            }


            //Wait before closing
            Console.ReadKey();
        }

        /*
        static void MeetAlien()
        {
            Random numberGen = new Random();
            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);
            Console.WriteLine("Hi I am " + name + "\nMy age is " + age + "\nI'm an Alien");
        }
        */

        static int primeChecker(int num1, int num2)
        {
            //A program if the number is Even or Uneven\\
            int result = num1 * num2;
            return result;
        }
    }
}
