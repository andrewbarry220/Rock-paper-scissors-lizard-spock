using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        //variables
        public string userChoice;
        
        
           
        //constructor




        //methods(can do)(can choose what they want to play)
        public void PlayerChoice()
        {
            Console.WriteLine("Please choose Rock, Paper, Scissors, Lizard, Spock");
            userChoice = Console.ReadLine().ToUpper();
            
           
        

        
        
        }



     }
}
