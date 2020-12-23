using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            //what is a for loop inside of a for loop? 
            //it's when you want to do a loop for every iteration of another loop
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + i + "\n");

                for (int k = i; k >= 0; k--)
                {
                    Console.Write(" " + k);
                }
            }
            //gotta learn matrix



            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
