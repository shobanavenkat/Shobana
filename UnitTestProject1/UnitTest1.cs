using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestShobanaLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTheAddMethod()
        {
            const int value1 = 4;
            const int value2 = 6;
            const int result = 10;

            var whiz = new MathWhiz();
            var classResult = whiz.Add(value1, value2);

            Assert.AreEqual(result, classResult);
        }

        [TestMethod]
        public void TestTheAddMethodAgain()
        {
            const int value1 = 14;
            const int value2 = 16;
            const int result = 30;

            var whiz = new MathWhiz();
            var classResult = whiz.Add(value1, value2);

            Assert.AreEqual(result, classResult);
        }

        [TestMethod]
        public void TestTheSubtractMethod()
        {
            const int value1 = 14;
            const int value2 = 8;
            const int result = 6;

            var whiz = new MathWhiz();
            var classResult = whiz.Subtract(value1, value2);

            Assert.AreEqual(result, classResult);
        }
    }
}
