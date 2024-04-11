using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds = 0;
            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            rounds = GetNumberOfRounds();

            for (int round = 1; round < rounds; round++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(rounds + " Rounds");
                Console.WriteLine();
                Console.WriteLine("Round " + round);

                Console.WriteLine("Press any key to roll dice");
                Console.ReadKey();

                int playerDiceValue = RollDice(random);
                Console.WriteLine("You Rolled a: " + playerDiceValue);
                Console.WriteLine();

                Console.WriteLine("Enemy is Rolling");
                System.Threading.Thread.Sleep(1000);

                int enemyDiceValue = RollDice(random);
                Console.WriteLine("Enemy Rolled a: " + enemyDiceValue);
                Console.WriteLine();

                if (playerDiceValue > enemyDiceValue)
                {
                    playerScore++;
                    Console.WriteLine("You Wins This Round!");
                    Console.WriteLine();
                }
                else if (enemyDiceValue > playerDiceValue)
                {
                    enemyScore++;
                    Console.WriteLine("Enemy Wins This Round!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("It's a Draw!");
                    Console.WriteLine();
                }

                Console.WriteLine("Score - Player: " + playerScore + ", Enemy: " + enemyScore);
                Console.WriteLine("----------------");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
            }
            if (playerScore > enemyScore)
            {
                Console.WriteLine("Congratulations, You Win The Game!");
            }
            else if (playerScore < enemyScore)
            {
                Console.WriteLine("Sorry, You Lose The Game!");
            }
            else
            {
                Console.WriteLine("The Game Ends In A Draw!");
            }
            Console.ReadKey();
        }

        static int GetNumberOfRounds()
        {
            int rounds = 0;
            while (true)
            {
                Console.WriteLine("Dice Game");
                Console.WriteLine("Select Number of Rounds:");
                Console.WriteLine("a. 5 Rounds");
                Console.WriteLine("b. 10 Rounds");
                Console.WriteLine("c. 15 Rounds");
                Console.Write("> ");

                string option = Console.ReadLine();

                if (option == "a" || option == "b" || option == "c")
                {
                    switch (option)
                    {
                        case "a":
                            rounds = 5;
                            break;
                        case "b":
                            rounds = 10;
                            break;
                        case "c":
                            rounds = 15;
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid option (a, b, or c).");
                }
            }
            return rounds;
        }
        static int RollDice(Random random)
        {
            return random.Next(1, 7);
        }
    }
}