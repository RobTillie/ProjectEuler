using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Euler.Solutions;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestProblem1()
        {
            var p = new Problem_1();
            var result = p.Solve();

            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void TestProblem2()
        {
            var p = new Problem_2();
            var result = p.Solve();

            Assert.AreEqual(4613732, result);
        }

        [TestMethod]
        public void TestProblem3()
        {
            var p = new Problem_3();
            var result = p.Solve();

            Assert.AreEqual(6857, result);
        }

        [TestMethod]
        public void TestProblem4()
        {
            var p = new Problem_4();
            var result = p.Solve();

            Assert.AreEqual(906609, result);
        }

        [TestMethod]
        public void TestProblem5()
        {
            var p = new Problem_5();
            var result = p.Solve();

            Assert.AreEqual(232792560, result);
        }
    }
}
