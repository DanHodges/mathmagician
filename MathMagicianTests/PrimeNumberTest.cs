using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTests
{
    [TestClass]
    public class PrimeNumberTest
    {
        [TestMethod]
        public void Prime_EnsureICanCreateClassInstance()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            Assert.IsNotNull(Prime);
        }

        [TestMethod]
        public void Prime_shouldPrintFirstNumber()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int expected = 1;
            int actual = Prime.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prime_shouldPrintNextNumber()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int input = 3;
            int expected = 5;
            int actual = Prime.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prime_shouldPrintAVariableSequenceOfNumbers()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 5, 7, 11, 13,17 };
            int[] actual = Prime.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Prime_printSequenceOfNumbers()
        {
            PrimeNumbers Prime = new PrimeNumbers();
            int length = 7;
            string expected = "1 2 3 5 7 11 13";
            string actual = Prime.ToString(Prime.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }
    }
}
