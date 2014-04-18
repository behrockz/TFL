using System;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    class TflRawDataParser : IRecordParser<TflRawData>
    {
        public TflRawData Parse(string[] record, DateTime timeStamp)
        {
            var stopName = record[1];
            var latitude = Convert.ToDouble(record[2]);
            var longitude = Convert.ToDouble(record[3]);
            var busName = record[4];
            var direction = Convert.ToInt32(record[5]);
            var vehicleRegistrationNumber = record[6];
            var estimatedArrivalTime = ParserUtility.ConvertUnixTimeToDateTime(record[7]);

            return new TflRawData(stopName, latitude, longitude, busName, direction, vehicleRegistrationNumber, estimatedArrivalTime, timeStamp);
        }
    }
}
