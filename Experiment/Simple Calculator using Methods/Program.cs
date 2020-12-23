using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int isDone = 0;
            while (isDone != 1)
            {
                try
                {
                    Console.WriteLine("Please Enter First Number To Calculate");
                    double input1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Operator (+, -, /, *)");
                    int input2 = 0;
                    int isTrue = 0;
                    while (isTrue != 1)
                    {
                        string process = Console.ReadLine();
                        switch (process)
                        {
                            case "+":
                                input2 = 1;
                                isTrue++;
                                break;
                            case "-":
                                input2 = 2;
                                isTrue++;
                                break;
                            case "/":
                                input2 = 3;
                                isTrue++;
                                break;
                            case "*":
                                input2 = 4;
                                isTrue++;
                                break;
                            default:
                                Console.WriteLine("Invalid Operator. Please Try Again");
                                break;
                        }
                    }

                    Console.WriteLine("Please Enter Second Number To Calculate");
                    double input3 = Convert.ToDouble(Console.ReadLine());

                    numCal(input1, input2, input3);//call the function with it's parameter
                    Console.ReadKey();//It waits for the input of the user before it close
                    isDone++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number Please Try Again");
                }
            }

        }
        static void numCal(double num01, int Operator, double num02)
        {
            switch (Operator)
            {
                case 1:
                    Console.WriteLine("The Result is: ");
                    Console.WriteLine(num01 + num02);
                    break;
                case 2:
                    Console.WriteLine("The Result is: ");
                    Console.WriteLine(num01 - num02);
                    break;
                case 3:
                    Console.WriteLine("The Result is: ");
                    Console.WriteLine(num01 / num02);
                    break;
                case 4:
                    Console.WriteLine("The Result is: ");
                    Console.WriteLine(num01 * num02);
                    break;
            }
        }
    }
}





