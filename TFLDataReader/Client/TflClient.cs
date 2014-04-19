using System.Collections.Generic;
using System.Configuration;
using RestSharp;
using TFLDataReader.Data;
using TFLDataReader.Parser;

namespace TFLDataReader.Client
{
    class TflClient<T> : ITflClient<T> where T : ITflRawData, new()
    {
        private readonly RestClient client;
        private readonly ITflResponseParser<T> tflResponseParser;

        public TflClient(ITflResponseParser<T> tflResponseParser)
        {
            this.tflResponseParser = tflResponseParser;
            string uri = ConfigurationManager.AppSettings["TflUri"]; 
            client = new RestClient(uri);
        }

        public IEnumerable<T> GetData(ITflRequest tflRequest, ReturnList returnList)
        {
            var request = tflRequest.GetRequest(returnList);

            var response = client.Execute(request);

            return tflResponseParser.ParsContent(response.Content);
        }
    }
}
