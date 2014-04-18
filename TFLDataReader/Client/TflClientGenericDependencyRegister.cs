using Microsoft.Practices.Unity;
using TFLDataReader.Data;
using TFLDataReader.Parser;
using TFLDataReader.Unity;

namespace TFLDataReader.Client
{
    class TflClientGenericDependencyRegister<T> : IGenericDependencyRegister<T> where T : ITflRawData
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<ITflClient, TflClient>();
            container.RegisterType<ITflResponseParser<T>, TflResponseParser<T>>();
            container.RegisterType(typeof(IRecordParser<T>), typeof(TflRawDataParser));
        }
    }
}
