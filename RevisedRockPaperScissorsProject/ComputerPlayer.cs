using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedRockPaperScissorsProject
{
    public class ComputerPlayer : Player
    {
        public ComputerPlayer()
        {
            name = "The Computer";
        }
        Random rnd = new Random();
        public void ChooseAtRandom()
        {
            playerChoice = rnd.Next(5);
        }
        public void DisplayComputerChoice()
        {
            switch (playerChoice)
            {
                case 0:
                    Console.WriteLine("The computer chooses rock");
                    break;
                case 1:
                    Console.WriteLine("The computer chooses paper");
                    break;
                case 2:
                    Console.WriteLine("The computer chooses scissors");
                    break;
                case 3:
                    Console.WriteLine("The computer chooses Spock");
                    break;
                case 4:
                    Console.WriteLine("The computer chooses lizard");
                    break;
                default:
                    break;
            }
        }
    }
}
