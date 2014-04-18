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
            new TflClientGenericDependencyRegister<ITflRawData>().Register(unity);
            var client = unity.Resolve<ITflClient>();

            var data = client.GetDataForAroundHere(new TflRequest(),
                                                   ReturnList.StopPointName | ReturnList.DirectionID |
                                                   ReturnList.EstimatedTime | ReturnList.Latitude | ReturnList.LineName |
                                                   ReturnList.Longitude | ReturnList.RegistrationNumber).ToArray();
        }
    }
}
