using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestWinningBoard1()
        {
            //arrange
            Player p1 = new Player
            {
                Name = "Dan",
                Marker = "X",
                IsTurn = true
            };

            Player p2 = new Player
            {
                Name = "Rich",
                Marker = "O",
                IsTurn = false
            };

            Game newGame = new Game(p1, p2);

            string[,] winBoard1 = new string[,]
            {
                {"1", "X", "3"},
                {"4", "X", "6"},
                {"7", "X", "9"},
            };

            newGame.Board.GameBoard = winBoard1;

            //assert
            Assert.True(newGame.CheckForWinner(newGame.Board));
        }
    }
}

