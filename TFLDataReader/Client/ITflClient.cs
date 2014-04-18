using System.Collections.Generic;
using TFLDataReader.Data;

namespace TFLDataReader.Client
{
    interface ITflClient
    {
        IEnumerable<ITflRawData> GetDataForAroundHere(TflRequest tflRequest, ReturnList returnList);
    }
}
