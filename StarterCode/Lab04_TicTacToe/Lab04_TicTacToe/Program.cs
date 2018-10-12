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
			// TODO: Instantiate your players DONE
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

            // Play the Game DONE
            Player winner = newGame.Play();

            // Output the winner DONE
            if (winner == null)
                Console.WriteLine("Nobody wins!");
            else
                Console.WriteLine($"{winner.Name} is the winner. Yay.");
		}
	}
}
