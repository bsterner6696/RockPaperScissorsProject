using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedRockPaperScissorsProject
{
    public class Player
    {
        public int playerChoice;
        public string name;

        public void GetName()
        {
            name = Console.ReadLine();

        }
        public void GetPlayerChoice()
        {
            string choice;
            choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "rock":
                    playerChoice = 0;
                    break;

                case "paper":
                    playerChoice = 1;
                    break;

                case "scissors":
                    playerChoice = 2;
                    break;

                case "spock":
                    playerChoice = 3;
                    break;
                case "lizard":
                    playerChoice = 4;
                    break;

                default:
                    Console.WriteLine("Enter a valid option.");
                    GetPlayerChoice();
                    break;
            }
        }

       
    }
}
