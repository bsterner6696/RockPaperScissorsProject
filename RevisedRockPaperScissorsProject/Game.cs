using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedRockPaperScissorsProject
{
    class Game
    {
        public int winner;

        HumanPlayer player1 = new HumanPlayer("player 1");
        SecondPlayer player2 = new SecondPlayer();
        
        public int DetermineWinner()
        {
            int result;

            result = (5 + player1.playerChoice - player2.playerChoice) % 5;

            return result;
        }

        public void AssignWinner()
        {
            int result;

            result = DetermineWinner();
            if (result == 0)
            {

                winner = 0;
            }
            else if (result % 2 == 1)
            {

                winner = 1;
            }
            else if (result % 2 == 0)
            {

                winner = 2;
            }

        }
        public void DeclareWinner()
        {
            if (winner == 0)
            {
                Console.WriteLine("It's a tie.");
            }
            else if (winner == 1)
            {
                Console.WriteLine("{0} wins", player1.name);
            }
            else if (winner == 2)
            {
                Console.WriteLine("{0} wins.", player2.name);
            };
        }
        public void InitializeGame()

        {
            Console.WriteLine("Enter 'human' to play with 2 people, or 'computer' to play alone.");
            player2.DetermineIfComputer();
            player1.name = "player 1";
            Console.WriteLine("Enter name for {0}.",player1.name);
            player1.GetName();            
            Console.WriteLine("Enter name for {0}.",player2.name);
            player2.GetName();
            PlayGame();
        }
        public void PlayGame()
        {
            Console.WriteLine("{0} chooses.", player1.name);
            player1.GetChoice();
            Console.Clear();
            Console.WriteLine("{0} chooses.", player2.name);
            player2.GetChoice();
            AssignWinner();
            DeclareWinner();
            PlayAgain();
        }
        public string AskToPlayAgain()
        {
            Console.WriteLine("Would you like to play again? (y/n)");
            string choice = Console.ReadLine();
            return choice;
        }

        public void PlayAgain()
        {
            string choice = AskToPlayAgain();
            switch (choice.ToLower())
            {
                case "y":
                case "yes":
                    PlayGame();
                    break;
                case "n":
                case "no":
                    Console.WriteLine("Thanks for playing!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Enter valid option.");
                    PlayAgain();
                    break;
            }
        }

    }
}
