using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Instructions();
            game1.ChoosePlayer2();                      
            game1.DetermineWinner();
        }
    }
}
