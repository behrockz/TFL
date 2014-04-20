using System;
using NUnit.Framework;
using TFLDataReader.Parser;

namespace TFLDataReaderTest.Parser
{
    [TestFixture]
    class TflRawRecordParserTest
    {
        [Test]
        public void ParseTest()
        {
            var o = new TflRawRecordParser<TestTflRawDataStub>();
            o.Parse(null, DateTime.Now);

            Assert.IsNotNull(o);
        }
    }
}
