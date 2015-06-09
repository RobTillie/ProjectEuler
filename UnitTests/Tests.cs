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
            var p1 = new Problem_1();
            var result = p1.Solve();

            Assert.AreEqual(233168, result);
        }

        [TestMethod]
        public void TestProblem2()
        {
            var p2 = new Problem_2();
            var result = p2.Solve();

            Assert.AreEqual(4613732, result);
        }        
    }
}
