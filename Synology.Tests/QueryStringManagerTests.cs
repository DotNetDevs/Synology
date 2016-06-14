using Microsoft.VisualStudio.TestTools.UnitTesting;
using Synology.Utilities;

namespace Synology.Tests
{
    [TestClass]
    public class QueryStringManagerTests
    {
        [TestMethod]
        public void QueryStringManagerArrayTest()
        {
            QueryStringManager manager = new QueryStringManager("http://test.com");

            manager.AddParameter(new QueryStringParameter("arrayParam", new string[] { "testString1", "testString2" }));

            var result = manager.ToString();

            Assert.AreEqual("http://test.com?arrayParam=testString1,testString2", result, "The QueryStringManager object does not processed the string array correctly");
        }
    }
}
