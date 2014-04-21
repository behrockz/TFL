using NUnit.Framework;
using TFLDataReader.Data;
using TFLDataReader.Request;

namespace TFLDataReaderTest.Request
{
    [TestFixture]
    public class FilterParameterTest
    {
        [Test]
        public void FilterParameter()
        {
            var p = new FilterParameter(ReturnList.Latitude);
            Assert.AreEqual("ReturnList", p.Name);
            Assert.AreEqual("Latitude", p.Value);
        }
    }
}