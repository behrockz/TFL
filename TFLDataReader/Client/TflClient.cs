using System.Collections.Generic;
using System.Configuration;
using RestSharp;
using TFLDataReader.Data;
using TFLDataReader.Parser;
using TFLDataReader.Request;

namespace TFLDataReader.Client
{
    internal class TflClient<T> : ITflClient<T> where T : ITflRawData, new()
    {
        private readonly IRestClient client;
        private readonly ITflResponseParser<T> tflResponseParser;

        public TflClient(ITflResponseParser<T> tflResponseParser, IRestClient client)
        {
            this.tflResponseParser = tflResponseParser;
            this.client = client;
        }

        public IEnumerable<T> GetData(ITflRequest tflRequest)
        {
            var request = tflRequest.GetRequest();

            var response = client.Execute(request);

            return tflResponseParser.ParsContent(response.Content);
        }
    }
}
