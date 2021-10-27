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
        public string playerGesture;
        

        //public string currentGesture;
        List<string> gestures = new List<string>() {"Rock","Paper","Scissors","Lizard","Spock"};
        




        //constructor
        public Player()
        {
            
        }
               


        //methods
        public abstract string ChooseGesture();


        
           
            
            
            
            
            
            
            
            
            
            
            
            
        



    }
}
