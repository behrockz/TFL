using System.Linq;
using Microsoft.Practices.Unity;
using TFLDataReader.Client;
using TFLDataReader.Data;

namespace TFLDataReader
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var unity = new UnityContainer();
            new TflClientGenericDependencyRegister<TflEstimatedBusArrivalTimeRawData2>().Register(unity);
            var client = unity.Resolve<ITflClient<TflEstimatedBusArrivalTimeRawData2>>();

            var data = client.GetData(new TflRequest(),
                                                   ReturnList.StopPointName | ReturnList.DirectionID |
                                                   ReturnList.EstimatedTime | ReturnList.Latitude | ReturnList.LineName |
                                                   ReturnList.Longitude | ReturnList.RegistrationNumber).ToArray();
        }
    }
}
