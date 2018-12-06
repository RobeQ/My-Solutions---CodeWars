using Sudoku.Strategies;
using Sudoku.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SudokuMapper sudokuMapper = new SudokuMapper();
                SudokuBoardStateManager sudokuBoardStateManager = new SudokuBoardStateManager();
                SudokuSolveEngine sudokuSolveEngine = new SudokuSolveEngine(sudokuBoardStateManager, sudokuMapper);
                SudokuFileReader sudokuFileReader = new SudokuFileReader();
                SudokuBoardDisplayer sudokuBoardDisplayer = new SudokuBoardDisplayer();

                Console.WriteLine("Please enter the filename containing the Sudoku Puzzle:");
                var filename = Console.ReadLine();

                var sudokuBoard = sudokuFileReader.SudokuReader(filename);
                sudokuBoardDisplayer.Display("Initial State", sudokuBoard);

                bool isSudokuSolved = sudokuSolveEngine.Solve(sudokuBoard);
                sudokuBoardDisplayer.Display("Final State", sudokuBoard);

                Console.WriteLine(isSudokuSolved
                    ? "You have successfully solved this Sudoku Puzzle!"
                    : "Unfortunatley, current algorithm(s) were not enough to solve the current Sudoku Puzzle!");
            }
            catch (Exception ex)
            {
                // In real world we would want to log this message
                Console.WriteLine("{0} : {1}", "Sudoku Puzzle cannot be solved because there was an error:", ex.Message);
            }
        }
    }
}
