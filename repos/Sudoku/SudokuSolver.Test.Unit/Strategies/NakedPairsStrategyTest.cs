using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku.Strategies;
using Sudoku.Workers;

namespace SudokuSolver.Test.Unit.Strategies
{
    [TestClass]
    public class NakedPairsStrategyTest
    {
        private readonly ISudokuStrategy _nakedPairStrategyTest = new NakedPairsStrategy(new SudokuMapper());

        [TestMethod]
        public void ShouldEliminateNumbersInRowBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {1, 2, 34, 5, 34, 6, 7, 348, 9 },
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var solvedSudokuBoard = _nakedPairStrategyTest.Solve(sudokuBoard);
            Assert.IsTrue(solvedSudokuBoard[0, 7] == 8);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInColBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {1, 0, 0, 0, 0, 0, 0, 0, 0},
                {2, 0, 0, 0, 0, 0, 0, 0, 0},
                {34, 0, 0, 0, 0, 0, 0, 0, 0},
                {5, 0, 0, 0, 0, 0, 0, 0, 0},
                {34, 0, 0, 0, 0, 0, 0, 0, 0},
                {6, 0, 0, 0, 0, 0, 0, 0, 0},
                {7, 0, 0, 0, 0, 0, 0, 0, 0},
                {348, 0, 0, 0, 0, 0, 0, 0, 0},
                {9, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var solvedSudokuBoard = _nakedPairStrategyTest.Solve(sudokuBoard);
            Assert.IsTrue(solvedSudokuBoard[7, 0] == 8);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlockBasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {1, 2, 34, 0, 0, 0, 0, 0, 0},
                {5, 34, 6, 0, 0, 0, 0, 0, 0},
                {7, 348, 9, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var solvedSudokuBoard = _nakedPairStrategyTest.Solve(sudokuBoard);
            Assert.IsTrue(solvedSudokuBoard[2, 1] == 8);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock5BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 9, 8, 7, 0, 0, 0},
                {0, 0, 0, 12, 6, 5, 0, 0, 0},
                {0, 0, 0, 12, 124, 3, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0}
            };

            var solvedSudokuBoard = _nakedPairStrategyTest.Solve(sudokuBoard);
            Assert.IsTrue(solvedSudokuBoard[5, 4] == 4);
        }

        [TestMethod]
        public void ShouldEliminateNumbersInBlock9BasedOnNakedPair()
        {
            int[,] sudokuBoard =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 1, 2, 3},
                {0, 0, 0, 0, 0, 0, 45, 6, 8},
                {0, 0, 0, 0, 0, 0, 45, 457, 9}
            };

            var solvedSudokuBoard = _nakedPairStrategyTest.Solve(sudokuBoard);
            Assert.IsTrue(solvedSudokuBoard[8, 7] == 7);
        }
    }
}
