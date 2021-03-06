﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTests
{
    [TestClass]
    public class NaturalNumbersTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            NaturalNumbers nats = new NaturalNumbers();
            Assert.IsNotNull(nats);
        }

        [TestMethod]
        public void shouldPrintFirstNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int expected = 1;
            int actual = nats.GetFirst();
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //[ExpectedException(typeof(AccessViolationException))]
        //public void NooneCanAccessPrivateDataMember()
        //{
        //    NaturalNumbers nats = new NaturalNumbers();
        //    nats.first;
        //}

        [TestMethod]
        public void shouldPrintNextNumber()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 1;
            int expected = 2;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void shouldPrintNextNumberInput3()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 3;
            int expected = 4;
            int actual = nats.GetNext(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void shouldPrintSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actual = nats.GetSequence();
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void shouldPrintAVariableSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 8;
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] actual = nats.GetSequence(input);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ShouldProvideSameSequences()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int input = 10;
            int[] sequenceWithLength = nats.GetSequence(input);
            int[] sequenceNoLength = nats.GetSequence();
            CollectionAssert.AreEqual(sequenceNoLength, sequenceWithLength);
        }

        [TestMethod]
        public void printSequenceOfNumbers()
        {
            NaturalNumbers nats = new NaturalNumbers();
            int length = 7;
            string expected = "1 2 3 4 5 6 7";
            string actual = nats.ToString(nats.GetSequence(length));
            Assert.AreEqual(expected, actual);
        }

        public string ToString(int[] array)
        {
            string output = "";
            for (int i = 0; i < array.Length; i++)
            {
                output += array[i].ToString() + " ";
            }
            return output.TrimEnd();
        }
    }
}