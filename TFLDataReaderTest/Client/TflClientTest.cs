using System.Linq;
using NUnit.Framework;
using RestSharp;
using Rhino.Mocks;
using TFLDataReader.Client;
using TFLDataReader.Data;
using TFLDataReader.Parser;
using TFLDataReader.Request;

namespace TFLDataReaderTest
{
    [TestFixture]
    class TflClientTest
    {
        [Test]
        public void GetDataTest()
        {
            var restClient = MockRepository.GenerateMock<IRestClient>();
            var request = MockRepository.GenerateMock<ITflRequest>();
            var parser = MockRepository.GenerateMock<ITflResponseParser<TestTflRawDataStub>>();

            const ReturnList returnList = ReturnList.DirectionID | ReturnList.LineID;

            request.Expect(r => r.GetRequest(returnList)).Return(null);
            var response = new RestResponse();
            response.Content = "";
            restClient.Expect(r => r.Execute(null)).Return(response);
            var testTflRawDataStub = new TestTflRawDataStub();
            parser.Expect(p => p.ParsContent(response.Content)).Return(new[] { testTflRawDataStub, });


            var client = new TflClient<TestTflRawDataStub>(parser, restClient);
            var result = client.GetData(request, returnList).ToArray();
            Assert.AreEqual(result.Length, 1);
            Assert.AreEqual(result[0], testTflRawDataStub);
        }
    }
}
