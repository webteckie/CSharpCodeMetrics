using CyclomaticComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeMetricsTests
{
    [TestClass]
    public class ElvisOperatorTests
    {
        [TestMethod]
        public void Process_WithNull_Should_ReturnEmpty()
        {
            var sut = new ElvisOperator();
            var result = sut.Process(null);

            Assert.AreEqual("Empty", result);
        }

        [TestMethod]
        public void Process_WithTop_Should_ReturnEmpty()
        {
            var position = new Top();

            var sut = new ElvisOperator();
            var result = sut.Process(position);

            Assert.AreEqual("Empty", result);
        }

        [TestMethod]
        public void Process_WithMiddle_Should_ReturnEmpty()
        {
            var position = new Top { Middle = new Middle() };

            var sut = new ElvisOperator();
            var result = sut.Process(position);

            Assert.AreEqual("Empty", result);
        }

        [TestMethod]
        public void Process__WithBottom_Should_ReturnBottom()
        {
            var position = new Top { Middle = new Middle { Bottom = new Bottom() } };

            var sut = new ElvisOperator();
            var result = sut.Process(position);

            Assert.AreEqual("Bottom", result);
        }
    }
}
