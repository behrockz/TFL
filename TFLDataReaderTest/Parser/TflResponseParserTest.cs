using System;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;
using TFLDataReader.Parser;

namespace TFLDataReaderTest.Parser
{
    [TestFixture]
    class TflResponseParserTest
    {
        [Test]
        public void ParsContentTest()
        {
            var rawParser =new TflRawRecordParser<TestTflRawDataStub>();
            var parser = new TflResponseParser<TestTflRawDataStub>(rawParser);
            var content = string.Format("[4,\"1.0\",1397848843000]{0}a,b{0}a,b{0}a,b{0}a,b{0}a,b", Environment.NewLine);
            var result = parser.ParsContent(content).ToArray();

            Assert.AreEqual(5, result.Length);
            Assert.AreEqual(Convert.ToDateTime("18/04/2014 19:20:43"), result[0].TimeStamp);
        }
    }
}
