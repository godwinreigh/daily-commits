using System;

namespace C_
{
    class Program
    {
        //Main = Entry Method (this where program starts)

        static void Main(string[] args)
        {
            //How to modify Properties of Console

            //wrench means is a variable or a property - these are things that we can change about our console such as color, title and size
            //box means it's a method or a function - these are commands that we can call in order to have a console do different things such us write a line of text or wait the user input

            Console.Title = "My Program";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;



            //How make console do something
            Console.WriteLine("Hello, what's your name");//() is called arguments.

            Console.ReadLine();//So you can type in console

            Console.WriteLine("Hello");//waits to finish the ReadLine function before it executes
            Console.ReadLine();//So you can type in console

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello too");

            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
