using System;

namespace TFLDataReader.Data
{
    public class TflRawData : ITflRawData
    {
        public string StopName { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string BusName { get; private set; }
        public int Direction { get; private set; }
        public string VehicleRegistrationNumber { get; private set; }
        public DateTime EstimatedArrivalTime { get; private set; }
        public DateTime TimeStamp { get; private set; }

        public TflRawData(string stopName, double latitude, double longitude, string busName, int direction, string vehicleRegistrationNumber, DateTime estimatedArrivalTime, DateTime timeStamp)
        {
            StopName = stopName;
            Latitude = latitude;
            Longitude = longitude;
            BusName = busName;
            Direction = direction;
            VehicleRegistrationNumber = vehicleRegistrationNumber;
            EstimatedArrivalTime = estimatedArrivalTime;
            TimeStamp = timeStamp;
        }
    }
}
