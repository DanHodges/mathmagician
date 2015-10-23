using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician;

namespace MathMagicianTests
{
    [TestClass]
    public class EvenTests
    {
        [TestMethod]
        public void EnsureICanCreateClassInstance()
        {
            EvenNumbers even = new EvenNumbers();
        }
    }
}
