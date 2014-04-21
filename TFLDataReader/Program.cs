using System.Linq;
using Microsoft.Practices.Unity;
using TFLDataReader.Client;
using TFLDataReader.Data;
using TFLDataReader.Request;

namespace TFLDataReader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unity = new UnityContainer();
            new TflClientGenericDependencyRegister<TflEstimatedBusArrivalTimeRawData>().Register(unity);
            var client = unity.Resolve<ITflClient<TflEstimatedBusArrivalTimeRawData>>();

            var tflRequest = new TflRequest(new FilterParameter(TflEstimatedBusArrivalTimeRawData.ReturnList));
            
            var data = client.GetData(tflRequest).ToArray();
        }
    }
}
