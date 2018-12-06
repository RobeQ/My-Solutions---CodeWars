using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Workers
{
    class SudokuFileReader
    {
        public int[,] SudokuReader(string filename)
        {
            int[,] sudokuBoard = new int[9, 9];

            try
            {
                var sudokuBoardLines = File.ReadAllLines(filename);

                int row = 0;
                foreach (var sudokuBoardLine in sudokuBoardLines)
                {
                    string[] sudokuBoardLineElements = sudokuBoardLine.Split('|').Skip(1).Take(9).ToArray();

                    int col = 0;
                    foreach (var sudokuBoardLineElement in sudokuBoardLineElements)
                    {
                        sudokuBoard[row, col] = sudokuBoardLineElement.Equals(" ") ? 0 : Convert.ToInt16(sudokuBoardLineElement);
                        col++;
                    }
                    row++;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Something went wrong with the application: " + ex.Message);
            }

            return sudokuBoard;
        }
    }
}
