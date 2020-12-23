using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int computerPoints = 0;
                int playerPoints = 0;
                int Draws = 0;
                int Repeats = 1;

                while (Repeats != 4)
                {
                    Console.WriteLine("Round: " + Repeats);
                    Random Computer = new Random();
                    string[] choices =
                    {
                "Rock",
                "Paper",
                "Scissors"
            };
                    int roll = 0;
                    roll = Computer.Next(1, 3);
                    string computerPicked = choices[roll];
                    Console.WriteLine("Please choose your choice: (R,P,S)");
                    string player = Console.ReadLine();
                    switch (player)
                    {
                        case "R":
                            player = "Rock";
                            break;
                        case "P":
                            player = "Paper";
                            break;
                        case "S":
                            player = "Scissors";
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                    if (player == "Rock" && computerPicked == "Paper")
                    //Computer Wins
                    {
                        Console.WriteLine("Computer uses " + computerPicked + " Computer Wins \n");
                        Repeats++;
                        computerPoints++;
                    }
                    else if (player == "Paper" && computerPicked == "Scissors")
                    {
                        Console.WriteLine("Computer uses " + computerPicked + " Computer Wins \n");
                        Repeats++;
                        computerPoints++;
                    }
                    else if (player == "Scissors" && computerPicked == "Rock")
                    {
                        Console.WriteLine("Computer uses " + computerPicked + " Computer Wins \n");
                        Repeats++;
                        computerPoints++;

                    }

                    //Player Wins
                    else if (player == "Paper" && computerPicked == "Rock")
                    {
                        Console.WriteLine("Computer uses " + computerPicked + "You Win \n");
                        Repeats++;
                        playerPoints++;
                    }
                    else if (player == "Scissors" && computerPicked == "Paper")
                    {
                        Console.WriteLine("Computer uses " + computerPicked + " You Win \n");
                        Repeats++;
                        playerPoints++;
                    }
                    else if (player == "Rock" && computerPicked == "Scissors")
                    {
                        Console.WriteLine("Computer uses " + computerPicked + " You Win \n");
                        Repeats++;
                        playerPoints++;
                    }
                    else if (player == computerPicked)
                    {
                        Console.WriteLine("Draw \n");
                        Repeats++;
                        Draws++;
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }

                if (computerPoints > playerPoints)
                {
                    Console.WriteLine("Computer Scored: " + computerPoints + " You Scored: " + playerPoints + "\n COMPUTER WINS");
                }
                else if (playerPoints > computerPoints)
                {
                    Console.WriteLine("Computer Scored: " + computerPoints + " You Scored: " + playerPoints + "\n PLAYER WINS");
                }
                else if (playerPoints == computerPoints)
                {
                    Console.WriteLine("Computer Scored: " + computerPoints + " You Scored: " + playerPoints + "\n DRAW");
                }

            }
            catch (FormatException)
            {
                Console.Write("Invalid");
            }

            Console.ReadKey();//It waits for the input of the user before it close
        }
    }
}
