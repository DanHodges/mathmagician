using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Fib_EnsureICanCreateClassInstance()
        {
            FibNumbers Fib = new FibNumbers();
            Assert.IsNotNull(Fib);
        }

        [TestMethod]
        public void Fib_shouldPrintFirstNumber()
        {
            FibNumbers Fib = new FibNumbers();
            int expected = 1;
            int actual = Fib.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Fib_shouldPrintNextNumber()
        //{
        //    FibNumbers Fib = new FibNumbers();
        //    int input = 2;
        //    int expected = 4;
        //    int actual = Fib.GetNext(input);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Fib_shouldPrintAVariableSequenceOfNumbers()
        //{
        //    FibNumbers Fib = new FibNumbers();
        //    int input = 8;
        //    int[] expected = new int[] { 1, 2, 3, 5, 7, 13, 17, 19, 27};
        //    int[] actual = Fib.GetSequence(input);
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Fib_printSequenceOfNumbers()
        //{
        //    FibNumbers Fib = new FibNumbers();
        //    int length = 7;
        //    string expected = "1 1 3 5 8 13";
        //    string actual = Fib.ToString(Fib.GetSequence(length));
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
