using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuBoard
{
    public class SudokuBoardGame
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entry Point");
        }
        public static int[,] Board = new int[9, 9];
        public SudokuBoardGame(int[,] board)
        {
            Board = board;
        }

        public bool SolveBoard()
        {
            bool rowsCorrect = SolveRows();
            bool colsCorrect = SolveCols();
            bool squaresCorrect = SolveSquares();
            if (rowsCorrect && colsCorrect && squaresCorrect)
            {
                return true;
            }
            return false;
        }

        public bool SolveRows()
        {
            bool rowsCorrect = true;
            for (int i = 0; i < 9; i++)
            {
                List<int> rowList = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    rowList.Add(Board[i, j]);
                }
                for (int k = 1; k < 10; k++)
                {
                    if (rowList.Contains(k))
                    {
                    }
                    else
                    {
                        int output = i + 1;
                        Console.WriteLine("row: " + output + "  does not contain: " + k);
                        rowsCorrect = false;
                    }
                }
            }
            Console.WriteLine("Rows Testing is: " + rowsCorrect);
            return rowsCorrect;
        }

        public bool SolveCols()
        {
            bool colsCorrect = true;
            for (int i = 0; i < 9; i++)
            {
                List<int> colList = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    colList.Add(Board[j, i]);
                }
                for (int k = 1; k < 10; k++)
                {
                    if (colList.Contains(k))
                    {
                    }
                    else
                    {
                        int output = i + 1;
                        Console.WriteLine("col: " + output + " does not contain: " + k);
                        colsCorrect = false;
                    }
                }
            }
            Console.WriteLine("Columns Testing is: " + colsCorrect);
            return colsCorrect;
        }
        public bool SolveSquares()
        {
            bool squaresCorrect = true;
            //There are 3 squares per row
            for (int i = 0; i < 3; i++)
            {
                //There are 3 squares per col
                for (int j = 0; j < 3; j++)
                {
                    List<int> squareList = new List<int>();
                    for (int rowElement = i * 3; rowElement < (i * 3) + 3; rowElement++)
                    {
                        for (int colElement = j * 3; colElement < (j * 3) + 3; colElement++)
                        {
                            //Console.Write(Board[rowElement,colElement] + ", ");
                            squareList.Add(Board[rowElement, colElement]);
                        }
                    }
                    for (int k = 1; k < 10; k++)
                    {
                        if (squareList.Contains(k))
                        {
                        }
                        else
                        {
                            Console.WriteLine("square: " + i + ", " + j + " does not contain: " + k);
                            squaresCorrect = false;
                        }
                    }
                    //Console.WriteLine();
                }
            }
            Console.WriteLine("Squares Testing is: " + squaresCorrect);
            return squaresCorrect;
        }
    }
}
