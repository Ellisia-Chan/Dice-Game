using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;
            string option;

            int rounds = 0;
            int roundTurn = 0;
            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            while (true)
            {
                Console.WriteLine("Dice Game");
                Console.WriteLine("Select Rounds");
                Console.WriteLine("a. 5 Rounds");
                Console.WriteLine("b. 10 Rounds");
                Console.WriteLine("c. 15 Rounds");
                Console.Write("> ");
                option = Console.ReadLine();
                Console.WriteLine();

                if (option.ToLower() == "a")
                {
                    rounds = 5;
                    break;
                }
                else if (option.ToLower() == "b")
                {
                    rounds = 10;
                    break;
                }
                else if (option.ToLower() == "c")
                {
                    rounds = 15;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a Valid Option");
                }
            }

            Console.WriteLine(rounds + " Rounds");
            for (int i = 0; i < rounds; i++)
            {
                roundTurn++;
                Console.WriteLine("Round " + roundTurn);
                Console.WriteLine("Press a Key to Roll the Dice");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You Rolled a: " + playerRandomNum);


                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy Rolled a: " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerScore++;
                    Console.WriteLine("Player Win This Round!");
                }
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyScore++;
                    Console.WriteLine("Enemy Win This Round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The Score is now - Player: " + playerScore + ". Enemy: " + enemyScore + ".");
                Console.WriteLine();
            }
            if (playerScore > enemyScore)
            {
                Console.WriteLine("Player Wins");
            }
            else if (enemyScore > playerScore)
            {
                Console.WriteLine("Enemy Wins!");

            }
            else
            {
                Console.WriteLine("Draw!");
            }

            Console.ReadKey();
        }
    }
}
