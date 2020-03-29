using System;

namespace DarkoPetrov.GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool winner = false;
            Random randomNumer = new Random();
            int winnningNumber;
            Console.Write("Set game difficulty: Easy(e), Normal(n) or Hard(h). How brave are you? ");
            string gameMode = Console.ReadLine();
            int userLives = 0;
            if (gameMode == "e")
            {
                
               winnningNumber = randomNumer.Next(0, 100);
                Console.WriteLine("Game difficulty set to Easy... Good Luck!!!");
                Console.WriteLine("");
                do
                {
                    Console.Write("Enter a number between 1 and 100: ");
                    int enteredNumber;
                    bool tryParse = int.TryParse(Console.ReadLine(), out enteredNumber);
                    if (enteredNumber < winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to low, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber > winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to high, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber == winnningNumber)
                    {
                        if(userLives == 0)
                        {
                            Console.WriteLine("Lucky Guess. Number entered: " + enteredNumber);
                        }

                        else if (userLives < 5)
                        {
                            Console.WriteLine("Good Enough. Number entered: " + enteredNumber);
                        }

                        else if (userLives > 5)
                        {
                            Console.WriteLine("You guessed it but you are so slow! Number entered: " + enteredNumber);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to end the game!");
                        Console.ReadLine();
                        winner = true;
                    }
                    userLives++;
                    if (userLives == 9)
                    {
                        Console.WriteLine("Do you want to try again? Y/N?: ");
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "y")
                        {
                            userLives = 0;
                            Console.WriteLine("Hope you do better this time :)");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time! See ya!");
                            Console.ReadLine();
                        }
                    }
                    Console.WriteLine("");
                    

                } while (winner == false && userLives < 9);
            }

            else if(gameMode == "n")
            {
                winnningNumber = randomNumer.Next(0, 500);
                Console.WriteLine("Game difficulty set to Normal... Good Luck!!!");
                Console.WriteLine("");
                do
                {
                    Console.Write("Enter a number between 1 and 500: ");
                    int enteredNumber;
                    bool tryParse = int.TryParse(Console.ReadLine(), out enteredNumber);
                    if (enteredNumber < winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to low, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber > winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to high, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber == winnningNumber)
                    {
                        if (userLives == 0)
                        {
                            Console.WriteLine("Lucky Guess. Number entered: " + enteredNumber);
                        }

                        else if (userLives < 4)
                        {
                            Console.WriteLine("Good Enough. Number entered: " + enteredNumber);
                        }

                        else if (userLives > 4)
                        {
                            Console.WriteLine("You guessed it but you are so slow! Number entered: " + enteredNumber);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Press any key to end the game!");
                        Console.ReadLine();
                        winner = true;
                    }
                    userLives++;
                    if (userLives == 7)
                    {
                        Console.WriteLine("Do you want to try again? Y/N?: ");
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "y")
                        {
                            userLives = 0;
                            Console.WriteLine("Hope you do better this time :)");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time! See ya!");
                            Console.ReadLine();
                        }
                    }
                    Console.WriteLine("");

                } while (winner == false && userLives < 7);
            }
            
            else if(gameMode == "h")
            {
                winnningNumber = randomNumer.Next(0, 700);
                Console.WriteLine("Game difficulty set to Hard... Good Luck!!!");
                Console.WriteLine("");
                do
                {
                    Console.Write("Enter a number between 1 and 700: ");
                    int enteredNumber;
                    bool tryParse = int.TryParse(Console.ReadLine(), out enteredNumber);
                    if (enteredNumber < winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to low, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber > winnningNumber)
                    {
                        Console.WriteLine("Your guess is far to high, number entered: " + enteredNumber);
                    }
                    else if (enteredNumber == winnningNumber)
                    {
                        if (userLives == 0)
                        {
                            Console.WriteLine("Lucky Guess. Number entered: " + enteredNumber);
                        }

                        else if (userLives < 3)
                        {
                            Console.WriteLine("Good Enough. Number entered: " + enteredNumber);
                        }

                        else if (userLives > 3)
                        {
                            Console.WriteLine("You guessed it but you are so slow! Number entered: " + enteredNumber);
                        }
                        Console.WriteLine("Press any key to end the game!");
                        Console.ReadLine();
                        winner = true;
                    }
                    userLives++;
                    if (userLives == 5)
                    {
                        Console.WriteLine("Do you want to try again? Y/N?: ");
                        string tryAgain = Console.ReadLine();
                        if (tryAgain == "y")
                        {
                            userLives = 0;
                            Console.WriteLine("Hope you do better this time :)");
                        }
                        else
                        {
                            Console.WriteLine("Better luck next time! See ya!");
                            Console.ReadLine();
                        }
                    }
                    Console.WriteLine("");

                } while (winner == false && userLives < 5);
            }
            Console.WriteLine("Better luck next time");
            Console.WriteLine("");
        }
    }
}
