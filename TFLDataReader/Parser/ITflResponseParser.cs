using System.Collections.Generic;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    internal interface ITflResponseParser<out T> where T : ITflRawData
    {
        IEnumerable<T> ParsContent(string content);
    }
}