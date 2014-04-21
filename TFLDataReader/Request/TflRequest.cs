using System;
using System.Collections.Generic;
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
        private readonly IRequestParameter[] requestparameters;

        public TflRequest(params IRequestParameter[] requestparameters)
        {
            this.requestparameters = requestparameters;
        }

        public RestRequest GetRequest()
        {
            var request = new RestRequest(resource, Method.GET);

            foreach (var requestparameter in requestparameters)
            {
                var parameter = new Parameter
                {
                    Name = requestparameter.Name,
                    Type = ParameterType.QueryString,
                    Value = requestparameter.Value
                };
                request.Parameters.Add(parameter);
            }

            return request;
        }
    }
}
