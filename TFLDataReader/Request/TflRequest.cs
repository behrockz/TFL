using System;
using System.Configuration;
using System.Linq;
using RestSharp;
using TFLDataReader.Client;
using TFLDataReader.Data;

namespace TFLDataReader.Request
{
    public class TflRequest : ITflRequest
    {
        private readonly string resource = ConfigurationManager.AppSettings["TflResource"];

        public RestRequest GetRequest(ReturnList returnList)
        {
            var request = new RestRequest(resource, Method.GET);

            var parameter = new Parameter
                {
                    Name = "ReturnList",
                    Type = ParameterType.QueryString,
                    Value = GetReturnList(returnList)
                };

            request.Parameters.Add(parameter);

            return request;
        }

        private string GetReturnList(ReturnList returnList)
        {
            var list = Enumerable.Range(0, Enum.GetNames(typeof (ReturnList)).Length)
                      .Select(p => (ReturnList)Math.Pow(2, p))
                      .Where(e => (returnList & e) == e);

            return string.Join(",", list);
        }
    }
}
