using System;

namespace TFLDataReader.Data
{
    public interface ITflRawData
    {
        DateTime TimeStamp { get; }

        void Initialize(string[] record, DateTime timeStamp);
    }
}