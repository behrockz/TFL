using System.Collections.Generic;
using TFLDataReader.Data;

namespace TFLDataReader.Client
{
    interface ITflClient
    {
        IEnumerable<ITflRawData> GetDataForAroundHere(ITflRequest tflRequest, ReturnList returnList); 
    }
}
