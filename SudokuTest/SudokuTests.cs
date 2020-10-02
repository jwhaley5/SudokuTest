using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SudokuBoard;

namespace SudokuTest
{
    [TestClass]
    public class SudokuTests
    {
        int[,] board1 = new int[9, 9] {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
        };

        int[,] board2 = new int[9, 9] {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 0, 3, 4, 8},
            {1, 0, 0, 3, 4, 2, 5, 6, 0},
            {8, 5, 9, 7, 6, 1, 0, 2, 0},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 0, 1, 5, 3, 7, 2, 1, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 0, 0, 4, 8, 1, 1, 7, 9}
        };

        [TestMethod]
        public void RowsCorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board1);
            Assert.IsTrue(Board.SolveRows());
        }

        [TestMethod]
        public void ColsCorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board1);
            Assert.IsTrue(Board.SolveCols());
        }

        [TestMethod]
        public void SquaresCorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board1);
            Assert.IsTrue(Board.SolveSquares());
        }

        [TestMethod]
        public void OverallSudokuCorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board1);
            Assert.IsTrue(Board.SolveBoard());
        }

        [TestMethod]
        public void RowsIncorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board2);
            Assert.IsFalse(Board.SolveRows());
        }

        [TestMethod]
        public void ColsIncorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board2);
            Assert.IsFalse(Board.SolveCols());
        }

        [TestMethod]
        public void SquaresIncorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board2);
            Assert.IsFalse(Board.SolveSquares());
        }

        [TestMethod]
        public void OverallSudokuIncorrect()
        {
            SudokuBoardGame Board = new SudokuBoardGame(board2);
            Assert.IsFalse(Board.SolveBoard());
        }

    }
}
