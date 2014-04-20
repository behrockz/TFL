using System;
using TFLDataReader.Data;

namespace TFLDataReaderTest
{
    internal class TestTflRawDataStub : ITflRawData
    {
        public DateTime TimeStamp { get; private set; }
        public void Initialize(string[] record, DateTime timeStamp)
        {
            TimeStamp = timeStamp;
        }
    }
}