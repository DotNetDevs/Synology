using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synology.Utilities;

namespace Synology.Tests
{
    [TestClass]
    public class QueryStringParameterTests
    {
        [TestMethod]
        public void TestEmptyParameters()
        {
            var parameter = new QueryStringParameter("param", string.Empty);
            var parameter2 = new QueryStringParameter(string.Empty, "param");

            Assert.AreEqual(string.Empty, parameter.ToString());
            Assert.AreEqual(string.Empty, parameter2.ToString());
            Assert.AreEqual(parameter.ToString(), parameter2.ToString());
        }

        [TestMethod]
        public void TestEnum()
        {
            var parameter = new QueryStringParameter("param", Synology.Tests.TestEnum.Test1 | Synology.Tests.TestEnum.Test2);

            var result = parameter.ToString();

            Assert.AreEqual("param=test1,test2", result);
        }

        [TestMethod]
        public void TestEnumBrackets()
        {
            var parameter = new QueryStringParameter("param", Synology.Tests.TestEnum.Test1 | Synology.Tests.TestEnum.Test2, true);

            var result = parameter.ToString();

            Assert.AreEqual("param=[test1,test2]", result);
        }

        [TestMethod]
        public void TestEnumerables()
        {
            var parameter = new QueryStringParameter("param", new[] { "test1", "test2" });

            var result = parameter.ToString();

            Assert.AreEqual("param=test1,test2", result);
        }

        [TestMethod]
        public void TestEnumerablesBrackets()
        {
            var parameter = new QueryStringParameter("param", new[] { "test1", "test2" }, true);

            var result = parameter.ToString();

            Assert.AreEqual("param=[test1,test2]", result);
        }
    }

    [Flags]
    public enum TestEnum
    {
        [System.ComponentModel.Description("test1")]
        Test1 = 1 << 0,

        [System.ComponentModel.Description("test2")]
        Test2 = 1 << 2,

        [System.ComponentModel.Description("test3")]
        Test3 = 1 << 3,
    }
}
