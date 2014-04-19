using System;
using TFLDataReader.Parser;

namespace TFLDataReader.Data
{
    public class TflEstimatedBusArrivalTimeRawData2 : ITflRawData
    {
        public string StopName { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string BusName { get; private set; }
        public int Direction { get; private set; }
        public string VehicleRegistrationNumber { get; private set; }
        public DateTime EstimatedArrivalTime { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public void Initialize(string[] record, DateTime timeStamp)
        {
            StopName = record[1];
            Latitude = Convert.ToDouble(record[2]);
            Longitude = Convert.ToDouble(record[3]);
            BusName = record[4];
            Direction = Convert.ToInt32(record[5]);
            VehicleRegistrationNumber = record[6];
            EstimatedArrivalTime = ParserUtility.ConvertUnixTimeToDateTime(record[7]);
            TimeStamp = timeStamp;
        }
    }
}
