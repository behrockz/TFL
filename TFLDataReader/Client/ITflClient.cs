using System.Collections.Generic;
using TFLDataReader.Data;

namespace TFLDataReader.Client
{
    interface ITflClient<out T> where T : ITflRawData
    {
        IEnumerable<T> GetData(ITflRequest tflRequest, ReturnList returnList); 
    }
}
