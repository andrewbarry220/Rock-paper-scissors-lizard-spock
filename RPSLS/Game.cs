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
        Player player1 = new Human();
        Player player2;
        int player1Score = 0;
        int player2Score = 0;
        int tie = 0;
        string player1Gesture;
        string player2Gesture;

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
            Console.Clear();
        }

        //method that will set player 2 based on the input of the user for wanting to play a 1 player game or a 2 player game
        public void ChoosePlayer2()
        {
            Console.WriteLine("Would you like to play 1 or 2 players");
            string userInput = Console.ReadLine();
            
            switch(userInput)
            {
                //creates a new computer player for a 1 player game
                case "1":
                    player2 = new Computer();
                    Console.WriteLine("You will verse the computer Will Wheaton");
                    break;

                //creating a new human player if the user chooses to play with a friend
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
           
        
        

        //method to compare the gestures that are recieved to know who won. 
        //then adds the score up as the winner is determined by the first player to 2 winning gestures
        public void CompareGesture()
        {
            if (player1Gesture == player2Gesture)
            {
                Console.WriteLine("You chose " + player1Gesture + " and the computer chose " + player2Gesture);
                Console.WriteLine("That is a tie");
                tie++;
            }

            else if (player1Gesture == "ROCK")
            {
                if (player2Gesture == "SCISSORS" || player2Gesture == "LIZARD")
                {
                    Console.WriteLine("You win, " + player1Gesture + " Crushes " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "PAPER")
                {
                    Console.WriteLine("You Lose, Paper Covers rock");
                    player2Score++;
                }
                else if (player2Gesture == "SPOCK")
                {
                    Console.WriteLine("You lose Spock vaporizes rock");
                    player2Score++;
                }
            }
            else if (player1Gesture == "PAPER")
            {
                if (player2Gesture == "ROCK")
                {
                    Console.WriteLine("You win, " + player1Gesture + " covers " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "SPOCK")
                {
                    Console.WriteLine("You win, " + player1Gesture + " disproves " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "SCISSORS")
                {
                    Console.WriteLine("You lose, scissors cuts paper");
                    player2Score++;
                }
                else if (player2Gesture == "LIZARD")
                {
                    Console.WriteLine("You lose, lizard eats paper");
                    player2Score++;
                }

            }

            else if (player1Gesture == "SCISSORS")
            {
                if (player2Gesture == "PAPER")
                {
                    Console.WriteLine("You win, " + player1Gesture + " cuts " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "LIZARD")
                {
                    Console.WriteLine("You win, " + player1Gesture + " decapitates " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "ROCK")
                {
                    Console.WriteLine("You lose, rock crushes scissors");
                    player2Score++;
                }
                else if (player2Gesture == "SPOCK")
                {
                    Console.WriteLine("You lose, Spock smashes scissors");
                    player2Score++;
                }

            }
            else if (player1Gesture == "LIZARD")
            {
                if (player2Gesture == "SPOCK")
                {
                    Console.WriteLine("You win, " + player1Gesture + "poisons " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "PAPER")
                {
                    Console.WriteLine("You win, " + player1Gesture + " eats " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "SCISSORS")
                {
                    Console.WriteLine("You lose, Scissors decapitates lizard");
                    player2Score++;
                }
                else if (player2Gesture == "ROCK")
                {
                    Console.WriteLine("You lose, rock crushes Lizard");
                    player2Score++;
                }
            }

            else if (player1Gesture == "SPOCK")
            {
                if (player2Gesture == "SCISSORS")
                {
                    Console.WriteLine("You win, " + player1Gesture + " smashes " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "ROCK")
                {
                    Console.WriteLine("You win, " + player1Gesture + " vaporizes " + player2Gesture);
                    player1Score++;
                }
                else if (player2Gesture == "PAPER")
                {
                    Console.WriteLine("You lose, paper disproces spock");
                    player2Score++;
                }
                else if (player2Gesture == "LIZARD")
                {
                    Console.WriteLine("You lose, lizard poisons Spock");
                    player2Score++;
                }


            }
          

        }

        //method to determine the winner of the game
        public void DetermineWinner()
        {
            while(player1Score < 2 && player2Score < 2)
            {
                player1Gesture = player1.ChooseGesture();
                player2Gesture = player2.ChooseGesture();
                CompareGesture();
            }
            if(player1Score == 2)
            {
                Console.WriteLine("Congrats Player 1! You have won!");
            }
            else
            {
                Console.WriteLine("Congrats Player 2! You have won!");
               
            }
            Console.ReadLine();
                 
        }

    }
           
        



      

}
    
 

 
