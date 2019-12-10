using CyclomaticComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeMetricsTests
{
    [TestClass]
    public class SwitchStatementsTests
    {
        [TestMethod]
        public void Process_Should_WorkForPast()
        {
            var dt = new DateTime(2018, 1, 1);

            var sut = new SwitchStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Past", result);
        }

        [TestMethod]
        public void Process_Should_WorkForPresent()
        {
            var dt = new DateTime(2019, 1, 1);

            var sut = new SwitchStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Present", result);
        }

        [TestMethod]
        public void Process_Should_WorkForFuture()
        {
            var dt = new DateTime(2050, 1, 1);

            var sut = new SwitchStatements();
            var result = sut.Process(dt);

            Assert.AreEqual("Future", result);
        }
    }
}
