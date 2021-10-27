using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Computer : Player
    {
        //member variables
       
        


        //constructor

        public Computer()
        {


        }






        //member methods
        //the computer will randomly generate a gesture to play against the user
        public override string ChooseGesture()
        {
            List<string> gestures = new List<string>() { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };
            Random random = new Random();
            int index = random.Next(gestures.Count);

            playerGesture = gestures[index];
            
                       
            switch(playerGesture)
            {
                case "1":
                    playerGesture = gestures[0];
                    break;
                case "2":
                    playerGesture = gestures[1];
                    break;
                case "3":
                    playerGesture = gestures[2];
                    break;
                case "4":
                    playerGesture = gestures[3];
                    break;
                case "5":
                    playerGesture = gestures[4];
                    break;
            }
            Console.WriteLine("The computer chose " + playerGesture);
            Console.ReadLine();
            return playerGesture;

                       
            
            
        }













    }
}
