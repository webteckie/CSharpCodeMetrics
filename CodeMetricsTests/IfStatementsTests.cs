using CyclomaticComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeMetricsTests
{
    [TestClass]
    public class IfStatementsTests
    {
        [TestMethod]
        public void Process_Should_WorkForPast()
        {
            var dt = new DateTime(2018, 1, 1);

            var sut = new IfStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Past", result);
        }

        [TestMethod]
        public void Process_Should_WorkForPresent()
        {
            var dt = new DateTime(2019, 1, 1);

            var sut = new IfStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Present", result);
        }

        [TestMethod]
        public void Process_Should_WorkForFuture()
        {
            var dt = new DateTime(2050, 1, 1);

            var sut = new IfStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Future", result);
        }
    }
}
