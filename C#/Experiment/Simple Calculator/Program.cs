using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 0;
            while (repeat != 1)
            {
                try
                {
                    Console.WriteLine("Please Enter First Number: ");
                    double firstNum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please Enter Second Number");
                    double secondNum = Convert.ToDouble(Console.ReadLine());

                    //isTrue Program
                    int isTrue = 0;
                    while (isTrue != 1)
                    {
                        Console.WriteLine("Please Enter the Operator: (+, -, *, /)");
                        string Operator = Console.ReadLine();
                        switch (Operator)
                        {
                            case "+":
                                Console.WriteLine(firstNum + secondNum);
                                isTrue++;
                                break;
                            case "-":
                                Console.WriteLine(firstNum - secondNum);
                                isTrue++;
                                break;
                            case "*":
                                Console.WriteLine(firstNum * secondNum);
                                isTrue++;
                                break;
                            case "/":
                                Console.WriteLine(firstNum / secondNum);
                                isTrue++;
                                break;

                            default:
                                Console.WriteLine("Invalid Operator");
                                break;
                        }
                    }

                    //isDone program
                    int inSwitch = 0;
                    while (inSwitch != 1)
                    {
                        Console.WriteLine("Done? Y/N");
                        string isDone = Console.ReadLine();
                        switch (isDone)
                        {
                            case "Y":
                                Console.WriteLine("Come Again");
                                inSwitch++;
                                repeat++;
                                break;
                            case "N":
                                Console.WriteLine("Then try again");
                                inSwitch++;
                                break;
                            default:
                                Console.WriteLine("Invalid");
                                break;
                        }
                    }
                }
                catch (FormatException)

                {
                    Console.WriteLine("Not a Number, Please try again");
                }
            }
            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
