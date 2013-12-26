using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolver.Tests
{
    [TestClass]
    public class SudokuSolverTests
    {
        private SudokuSolver sudokuSolver;

        [TestInitialize]
        public void TestInitialize()
        {
            sudokuSolver = new SudokuSolver();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            sudokuSolver = null;
        }
        
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
