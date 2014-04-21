using System.Collections.Generic;
using TFLDataReader.Data;
using TFLDataReader.Request;

namespace TFLDataReader.Client
{
    public interface ITflClient<out T> where T : ITflRawData
    {
        IEnumerable<T> GetData(ITflRequest tflRequest); 
    }
}
