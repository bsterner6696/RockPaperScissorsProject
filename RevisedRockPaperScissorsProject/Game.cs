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
        Player player1;
        Player player2;
        bool isComputer;


        public void DetermineIfComputer()
        {
            string choice;
            choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "computer":
                    isComputer = true;
                    break;
                case "human":
                    isComputer = false;
                    break;
                default:
                    Console.WriteLine("Enter valid choice. 'computer' or 'human'");
                    DetermineIfComputer();
                    break;
            }
        }
        public void GeneratePlayers()
        {
            Console.WriteLine("Enter 'human' to play with 2 people, or 'computer' to play alone.");
            DetermineIfComputer();
            if (isComputer) {

                player1 = new HumanPlayer("player 1");
                player2 = new ComputerPlayer();

            }

            else if (!isComputer)
            {
                player1 = new HumanPlayer("player 1");
                player2 = new HumanPlayer("player 2");
            }

            
        }
        
  
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
        public void Initialize()

        {
            
            GeneratePlayers();
            player1.GetName();
            player2.GetName();
            PlayGame();
        }
        public void PlayGame()
        {
            
            player1.GetChoice();
            Console.Clear();
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
