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

        //[TestMethod]
        //public void Prime_shouldPrintNextNumber()
        //{
        //    PrimeNumbers Prime = new PrimeNumbers();
        //    int input = 2;
        //    int expected = 4;
        //    int actual = Prime.GetNext(input);
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Prime_shouldPrintAVariableSequenceOfNumbers()
        //{
        //    PrimeNumbers Prime = new PrimeNumbers();
        //    int input = 8;
        //    int[] expected = new int[] { 2, 4, 6, 8, 10, 12, 14, 16 };
        //    int[] actual = Prime.GetSequence(input);
        //    CollectionAssert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void Prime_printSequenceOfNumbers()
        //{
        //    PrimeNumbers Prime = new PrimeNumbers();
        //    int length = 7;
        //    string expected = "2 4 6 8 10 12 14";
        //    string actual = Prime.ToString(Prime.GetSequence(length));
        //    Assert.AreEqual(expected, actual);
        //}
    }
}
