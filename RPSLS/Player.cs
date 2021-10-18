using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //member variables
        public string chosenGesture;

        //public string currentGesture;
        List<string> gestures = new List<string>() {"Rock","Paper","Scissors","Lizard","Spock"};
        




        //constructor
        public Player()
        {
            
        }


        //methods
        public void ChooseGesture()
        {
            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, Spock");
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
                
            }

            chosenGesture = Console.ReadLine();
            
            
            //showing the gestures and then taking chosen gesture
            //store choice as user input
        }



    }
}
