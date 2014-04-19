using System;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    public interface IRawRecordParser<out T> where T : ITflRawData, new()
    {
        T Parse(string[] record, DateTime timeStamp);
    }
}