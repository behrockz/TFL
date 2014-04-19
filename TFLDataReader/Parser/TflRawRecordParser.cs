﻿using System;
using Microsoft.Practices.Unity;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    class TflRawRecordParser<T> : IRawRecordParser<T> where T : ITflRawData , new()
    {
        public T Parse(string[] record, DateTime timeStamp)
        {
            var t = new T();
            t.Initialize(record, timeStamp);
            return t;
        }
    }
}
