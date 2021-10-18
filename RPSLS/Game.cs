using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //game variables(needs 2 players to play the game)
        Human player1 = new Human();
        Player player2;
        int player1Score;
        int player2Score;
          

        //constructor
        public Game()
        {
                     

        }

                      

        //methods
        

        public void Instructions()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock! \n" + 
                "Rock crushes Scissors! \n" + "Scissors cuts Paper! \n" + "Paper covers Rock! \n" + "Rock crushes Lizard! \n" + 
                "Lizard poions Spock! \n" + "Spock smashes Scissors! \n" + "Scisors decapitates Lizard! \n" + "Lizard eats Paper! \n" +
                "Paper disproves Spock! \n" + "Spock vaporizes Rock!\n" +
                "Best 2/3 to win the match");
            Console.ReadLine();
        }

        public void ChoosePlayer2()
        {
            Console.WriteLine("Would you like to play 1 or 2 players");
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    player2 = new Computer();
                    Console.WriteLine("You will verse the computer Will Wheaton");
                    
                    break;

                case "2":
                    player2 = new Human();
                    Console.WriteLine("You will be versing your friend");
                    break;

                default:
                    Console.WriteLine("That is not a valid response");
                    Console.ReadLine();
                    Console.Clear();
                    ChoosePlayer2();
                    break;
            }

        }
           
        public void Player1Gesture()
        {
            player1.ChooseGesture();
            
        }
        public void Player2Gesture()
        {
            player2.ChooseGesture();
        }
        public void CompareGesture()
        {
            //player1 chosen gesture v player2 chosen gesture
            //if player 1 wins add point, if player 2 wins add point
            //once a player gets to 2 points the game is over,display victory message
            //if not at 2 points it needs to restart 

        }

    
    }

   
    


    







}
