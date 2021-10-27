using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        //variables




        //constructor
        public Human()
        {

        }



        //methods(can do)(can choose what they want to play)

        //This allows the human player to choose their gesture 
        public override string ChooseGesture()
        {
            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, Spock");
            playerGesture = Console.ReadLine().ToUpper();
            Console.WriteLine("You chose " + playerGesture);
            Console.ReadLine();
            return playerGesture;
        
        }



       



    }
}
