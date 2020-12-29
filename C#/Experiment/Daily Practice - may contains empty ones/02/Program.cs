using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            //use var when handling List cause it handles both int and string
            var names = new List<string> { "name", "Ana", "Felipe" };
            names.Add("Maria");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine(names.Count);

            var index = names.IndexOf("Felipe");//returns -1 if the item is not found
            Console.WriteLine(index);

            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            else
            {
                var notFound = names.IndexOf("Not Found");
                Console.WriteLine($"When an item is not found, IndexOf return {notFound}");
            }

            //Sort
            names.Sort();
            Console.WriteLine("-------------------------");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            Console.ReadKey();
        }
    }
}
