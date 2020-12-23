using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a Sentence");
            string sentence = Console.ReadLine();

            int wordCount = senCounter(sentence);

            Console.WriteLine($"There are {wordCount} sentence");
            
            Console.ReadKey();
        }

        static int senCounter(string sentence)
        {

            //When using split it needs to be converted to string to Integer
            //MY OWN EXPLANATION 
            //to do that we use Length which counts the Length of the string that returns an integer
            //then if split argument satisfied/meets within string index value it will form an array
            //EXAMPLE
            //input = My name is John
            //split argument will look it's pair then it will be satisfied leaving the other characters to be in array
            //meaning the space will be it's pair then it will be the sign to the computer will know that he is going to make an array and to stop make array
            //in short words split argument is looking for the sign where the array should be splitted
            //split arguement will only read array when it's value is based in its index which that explains the split variable needs to be an integer

            int wordCount = sentence.Split(' ').Length;//string splits into array when it detects space or empty character

            return wordCount;
        }
    }

}
