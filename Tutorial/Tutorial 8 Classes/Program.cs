//NOTES\\
//in classes we describe objects
//which is Object Oriented Programming
//We give details to them or make it's blueprint
//And the input of the result will be depends to the blueprint

//the public stands for access modifier, it defines where we can access the variable and methods from
//public means you can access it outside of the class
//private means you can only access the variable or method from inside the class itself

using System;

namespace Tutorial_8_Classes
{
    /*
    class Dog
    {
        //declaring variables for the description
        public string name;
        public int age;

        //declaring a method what the class should do
        public void Bark()
        {
            Console.WriteLine($"{name} says Rrrrr, and his age is {age}");

        }
    }
    */

    //we do this outside of the class program


    class Fighter
    {
        //blueprint
        public string name;
        public string favMove;

        //change it to private when you want only it to acess inside of the class
        private int stamina;//
        private float exp;

        //static and void classes
        public static int TotalFighters;

        ////////////////////////////////////////////////////
        //creating constructor
        //we use constructor if you want something to be default and this makes your code shorter than using instance method

        public Fighter(string _name, string _favMove)//you can also use parameter to assign changeable values
        {
            //when you create fighter it goes by here first
            TotalFighters++;
            name = _name;
            favMove = _favMove;

            //this two values can be only change here inside of this class due to private method
            stamina = 10;
            exp = 0f;
        }
        ////////////////////////////////////////

        ///////////////////////////////////////////////////////
        //what fighter should do based to the blueprint(METHODS)



        public void move()
        {
            //if stamina is still greater than 0 do this else exit();
            if (stamina > 0)
            {
                //for everytime the move() method happens, decrease the stamina value of the fighter01
                Console.WriteLine($"Stamina: {stamina}");

                Console.WriteLine($"{name} used {favMove}");

                stamina -= 5;//I can also just do this to assign itteration value

                Console.WriteLine($"Stamina: {stamina}");

                exp += 0.3f;//increase exp

                Console.WriteLine($"\nExprience Gained: {exp}");//You can also do this to get one value of the class
            }
            else
            {
                Console.WriteLine($"Stamina: {stamina}\nStamina is Depleted, move unable to use.");
            }
        }
        public void rest()
        {
            stamina = 10;
            Console.WriteLine($"\nYou rested, your stamina is now {stamina}");
        }
        /////////////////////////////////////////////////////// 
    }


    class Program
    {
        static void Main(string[] args)
        {
            /*
            //This part is Called creating an Instance for the class or creating the class based on it's blueprint
            Dog dog01 = new Dog();
            dog01.name = "doggo";
            dog01.age = 3;

            dog01.Bark();
            */

            //Instantiate or declare value to variables
            Fighter fighter01 = new Fighter("Rob", "Punch");
            Fighter fighter02 = new Fighter("John", "Kick");

            //automatically done using constructor
            //fighter01.name = "Rob";
            //fighter01.favMove = "Punch";
            //fighter01.stamina = 10;
            //fighter01.exp = 0f;//we use 0f because it will give us an error when it became a decimal for some reason

            Console.WriteLine("-----First Move--------");
            fighter01.move();

            Console.WriteLine("\n-----Second Move-------");
            fighter01.move();

            Console.WriteLine("\n-----Third Move-------");
            fighter01.move();

            fighter01.rest();

            Console.WriteLine("\n-----Fourth Move-------");
            fighter01.move();

            //get the value of variable TotalFighters
            //this is allows us doing this by static method, we can get the value inside of the another class using the . only
            //for example Console.WriteLine which .WriteLine is a static method
            Console.WriteLine(Fighter.TotalFighters);

            Console.ReadLine();
        }
    }
}
