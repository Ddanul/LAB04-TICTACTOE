using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            PlayGame();
		}

		static void PlayGame()
		{
			// TODO: Instantiate your players
            Console.Write("Please enter name for Player 1: ");
            string playerOneName = Console.ReadLine();
            Console.Write("Please enter name for Player 2: ");
            string playerTwoName = Console.ReadLine();
            
            Player p1 = new Player
            {
                Name = playerOneName,
                Marker = "X",
                IsTurn = true
            };

            Player p2 = new Player
            {
                Name = playerTwoName,
                Marker = "O",
                IsTurn = false
            };
            
            // Create the Game DONE
            Game newGame = new Game(p1, p2);

            Player winner = newGame.Play();

            //newGame.Board.DisplayBoard();


            // Take turn for player 1 ?

			// Play the Game
			// Output the winner
		}
	}
}
