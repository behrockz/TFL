using Microsoft.Practices.Unity;
using TFLDataReader.Data;
using TFLDataReader.Parser;
using TFLDataReader.Unity;

namespace TFLDataReader.Client
{
    class TflClientGenericDependencyRegister<T> : IGenericDependencyRegister<T> where T : ITflRawData , new()
    {
        public void Register(UnityContainer container)
        {
            container.RegisterType<ITflClient<T>, TflClient<T>>();
            container.RegisterType<ITflResponseParser<T>, TflResponseParser<T>>();
            container.RegisterType<IRawRecordParser<T>, TflRawRecordParser<T>>();
        }
    }
}
