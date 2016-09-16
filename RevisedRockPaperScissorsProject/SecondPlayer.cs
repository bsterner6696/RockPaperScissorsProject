using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedRockPaperScissorsProject
{
    public class SecondPlayer : Player
    {
        public SecondPlayer()
        {
            name = "Computer";
        }
        Random rnd = new Random();
        public override void GetChoice()
        {
            if (isComputer)
            {
                playerChoice = rnd.Next(5);
                DisplayComputerChoice();
            } else
            {
                base.GetChoice();
            }
        }
        public void DisplayComputerChoice()
        {
            switch (playerChoice)
            {
                case 0:
                    Console.WriteLine("{0} chooses rock",name);
                    break;

                case 1:
                    Console.WriteLine("{0} chooses paper",name);
                    break;

                case 2:
                    Console.WriteLine("{0} chooses scissors",name);
                    break;

                case 3:
                    Console.WriteLine("{0} chooses Spock",name);
                    break;

                case 4:
                    Console.WriteLine("{0} chooses lizard",name);
                    break;

                default:
                    break;
            }
        }
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
                    name = "player 2";
                    break;
                default:
                    Console.WriteLine("Enter valid choice. 'computer' or 'human'");
                    DetermineIfComputer();
                    break;
            }
        }
    }
}
