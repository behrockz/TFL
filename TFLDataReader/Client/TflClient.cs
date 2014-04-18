using System.Collections.Generic;
using System.Configuration;
using RestSharp;
using TFLDataReader.Data;
using TFLDataReader.Parser;

namespace TFLDataReader.Client
{
    class TflClient : ITflClient
    {
        private readonly RestClient client;
        private readonly ITflResponseParser<ITflRawData> tflResponseParser;

        public TflClient(ITflResponseParser<ITflRawData> tflResponseParser)
        {
            this.tflResponseParser = tflResponseParser;
            string uri = ConfigurationManager.AppSettings["TflUri"]; 
            client = new RestClient(uri);
        }

        public IEnumerable<ITflRawData> GetDataForAroundHere(ITflRequest tflRequest, ReturnList returnList)
        {
            var request = tflRequest.GetRequest(returnList);

            var response = client.Execute(request);

            return tflResponseParser.ParsContent(response.Content);
        }
    }
}
