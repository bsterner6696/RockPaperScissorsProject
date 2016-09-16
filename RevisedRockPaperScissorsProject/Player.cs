using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisedRockPaperScissorsProject
{
    abstract public class Player
    {
        public int playerChoice;
        public string name;


        public bool isComputer;
        
        public virtual void GetName()
        {
            Console.WriteLine("Enter name for {0}.", name);
            name = Console.ReadLine();
        }
        public virtual void GetChoice()
        {
            Console.WriteLine("{0} chooses.", name);
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
                    GetChoice();
                    break;
            }
        }
        

    }
}
