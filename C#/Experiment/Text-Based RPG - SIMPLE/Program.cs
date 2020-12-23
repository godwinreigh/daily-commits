using System;

namespace Text_Based_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name of your Character");
            string input1 = Console.ReadLine();
            Console.WriteLine("Spider Engaged the battle\n");


            MainChar mc = new MainChar(input1);
            Spider monster1 = new Spider();


            while (Spider.health > 0)
            {

                int isTrue = 0;
                while (isTrue != 1)
                {

                    Console.WriteLine("What Should Player Do? (Attack) ");//other methods not done yet
                    string choiceInput = Console.ReadLine().ToLower();
                    switch (choiceInput)
                    {
                        case "attack":
                            Console.WriteLine("Choose your move: Kick, Punch");
                            string input2 = Console.ReadLine().ToUpper();
                            switch (input2)
                            {
                                case "KICK":
                                    input2 = "Kick";
                                    isTrue++;
                                    break;
                                case "PUNCH":
                                    input2 = "Punch";
                                    isTrue++;
                                    break;
                                default:
                                    Console.WriteLine("Error 103");
                                    break;
                            }
                            if (isTrue == 1)
                            {
                                mc.attack(input2);
                            }
                            else
                            {
                                Console.WriteLine("Error 102");
                            }
                            break;
                        default:
                            Console.WriteLine("Error 101");
                            break;
                    }
                    if (Spider.health > 0)
                    {
                        monster1.attack();
                    }
                }
            }
            Console.WriteLine(MainChar.exp);
            if (MainChar.exp >= 0.3)
            {
                Console.WriteLine("You Level Up");
            }
            Console.ReadLine();
        }
    }
    class MainChar
    {
        public static string MainCharName;
        //public string moves;

        public static int damage;
        public static int health;
        public static int defense;
        public static float exp;
        public MainChar(string _MainCharName)
        {
            MainCharName = _MainCharName;
            health = 10;
            damage = 5;
            exp = 0f;
            defense = 3;
        }

        public void attack(string _attack)
        {
            string monsterName = Spider.spiderName;

            if (Spider.health >= 0)
            {
                int outcome1 = MainChar.health -= Spider.damage;
                int outcome2 = Spider.health -= MainChar.damage;
                Console.WriteLine($"{MainChar.MainCharName} used {_attack} to attacked the spider");
                Console.WriteLine($"{MainChar.MainCharName} health: {outcome1}");
                Console.WriteLine($"Spider Health: {outcome2}\n");

                if (MainChar.health < 0)
                {
                    Console.WriteLine("You Died");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if (Spider.health <= 0)
                {
                    MainChar.exp += 0.3f;
                    Console.WriteLine($"You defeated the {monsterName}");
                }
            }
            else
            {

                Console.WriteLine($"{MainChar.MainCharName} Died to {monsterName}");
            }
        }
    }

    class Spider
    {
        public static string spiderName;
        public static int damage;
        public static int health;

        public Spider()
        {
            spiderName = "Spider";
            damage = 4;
            health = 6;
        }
        public void attack()
        {
            MainChar.health -= damage;
            Console.WriteLine($"Spider Attacked you, your health is now {MainChar.health}");
        }
    }
}
