using System.Configuration;
using Microsoft.Practices.Unity;
using RestSharp;
using TFLDataReader.Data;
using TFLDataReader.Parser;
using TFLDataReader.Unity;

namespace TFLDataReader.Client
{
    public class TflClientGenericDependencyRegister<T> : IGenericDependencyRegister<T> where T : ITflRawData , new()
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<ITflClient<T>, TflClient<T>>();
            container.RegisterType<ITflResponseParser<T>, TflResponseParser<T>>();
            container.RegisterType<IRawRecordParser<T>, TflRawRecordParser<T>>();

            var baseUri = ConfigurationManager.AppSettings["TflUri"];
            container.RegisterType<IRestClient, RestClient>(new InjectionConstructor(baseUri));
        }
    }
}
