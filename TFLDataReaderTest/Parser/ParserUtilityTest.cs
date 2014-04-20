using System;
using NUnit.Framework;
using TFLDataReader.Parser;

namespace TFLDataReaderTest.Parser
{
    [TestFixture]
    class ParserUtilityTest
    {
        [Test]
        public void ConvertUnixTimeToDateTimeTest()
        {
            var d = ParserUtility.ConvertUnixTimeToDateTime("[1397848843000]");
            Assert.AreEqual(Convert.ToDateTime("18/04/2014 19:20:43"), d);
        }

        [Test]
        public void ConvertUnixTimeToDateTime()
        {
            var d = ParserUtility.ConvertUnixTimeToDateTime(1397848843000);
            Assert.AreEqual(Convert.ToDateTime("18/04/2014 19:20:43"), d);
        }

        [Test]
        public void Trim()
        {
            var d = ParserUtility.Trim("[1397848843000]");
            Assert.AreEqual("1397848843000", d);
        }
    }
}
