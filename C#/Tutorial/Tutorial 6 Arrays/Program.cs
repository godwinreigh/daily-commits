using System;//The default namespace
             //when creating a game, developers uses multiple namespaces, one for graphics, dedicated audio, etc.
using System.Collections.Generic; //namespace for list 
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {



            //basic program for looping array\\

            /*
            string[] names =
            {
                //indexes starts 0
                "Gob",
                "Caesar",
                "Dio",
                "Nani"
            };
            //names.Lenght checks the index lenght of an array
            for (int i = 0; i < names.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + names[i]);
            }
            */




            /*

            //another program

            //empty array that will be filled by the user then sort it by the computer alphabetacally\\

            string[] movies = new string[4]; //[4] stand for the lenght of the index or how many elements we want to array to store
            Console.WriteLine("Type in Four Movies: ");

            //itterate first
            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");
            Array.Sort(movies);//Array.Sort function, you can sort the array a-z; you can do this if you have bunch of number as well which going to sort them to ascending order

            //then execute
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine(movies[i]);
            }

            //Conclusion: You can use array and for loops in working many items
            //Disadvantage of using array: They have always has a fix size, therefore we use a list of don't know how many items we gonna store

            //Lists - You don't have to specify the lenght, is totally reziable.
            */





            /*
            //program for lists (includes namespace)\\

            List<string> shoppingList = new List<string>();//creating empty list;

            shoppingList.Add("Car");
            shoppingList.Add("Boat");
            shoppingList.Add("Plane");
            shoppingList.Add("Train");

            //looping through the list

            //We cannot use Lenght, We can only use Count in working with Lists
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            //we can easily remove from Lists than array
            shoppingList.Remove("Car");
            shoppingList.RemoveAt(0);//you can also remove using index

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Remaining Items \n");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            Console.WriteLine("\n--------------------------------");
            Console.ReadKey();//It waits for the input of the user before it close
            */




            //CHALLENGE (ARRAYS)\\
            /*
            try
            {
                Console.Write("How many students in the class? ");
                int numOfStd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the name of the students");
                string[] students = new string[numOfStd];
                for (int i = 0; i < students.Length; i++)
                {
                    students[i] = Console.ReadLine();
                }
                //sort
                Array.Sort(students);

                //execute
                Console.WriteLine("Students here in Alphabetacally");

                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine("Hello Student " + students[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid");
            }
            */




            //CHALLENGE (LISTS)\\
            try
            {
                List<string> Students = new List<string>(); //create empty List
                Console.WriteLine("How many Students? ");
                int numOfStd = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please specify the Students");

                for (int i = 0; i < numOfStd; i++)
                {
                    string add = Console.ReadLine();
                    Students.Add(add);
                }
                Students.Sort();//Sort the List
                Console.WriteLine("---------------------");
                for (int i = 0; i < Students.Count; i++)
                {
                    Console.WriteLine("Hello Student " + Students[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid");
            }


            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
