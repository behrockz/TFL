using System;
using TFLDataReader.Parser;

namespace TFLDataReader.Data
{
    public class TflEstimatedBusArrivalTimeRawData : ITflRawData
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
            StopName = ParserUtility.Trim(record[1]);
            Latitude = Convert.ToDouble(ParserUtility.Trim(record[2]));
            Longitude = Convert.ToDouble(ParserUtility.Trim(record[3]));
            BusName = ParserUtility.Trim(record[4]);
            Direction = Convert.ToInt32(ParserUtility.Trim(record[5]));
            VehicleRegistrationNumber = ParserUtility.Trim(record[6]);
            EstimatedArrivalTime = ParserUtility.ConvertUnixTimeToDateTime(ParserUtility.Trim(record[7]));
            TimeStamp = timeStamp;
        }

        public static ReturnList ReturnList 
        {
            get
            {
                return ReturnList.StopPointName | ReturnList.DirectionID | ReturnList.EstimatedTime | ReturnList.Latitude | ReturnList.LineName | ReturnList.Longitude | ReturnList.RegistrationNumber;
            }
        }
    }
}
