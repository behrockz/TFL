using System;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    public interface IRecordParser<out T> where T : ITflRawData
    {
        T Parse(string[] record, DateTime timeStamp);
    }
}