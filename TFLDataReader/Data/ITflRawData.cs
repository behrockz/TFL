using System;

namespace TFLDataReader.Data
{
    public interface ITflRawData
    {
        string StopName { get; }
        double Latitude { get; }
        double Longitude { get; }
        string BusName { get; }
        int Direction { get; }
        string VehicleRegistrationNumber { get; }
        DateTime EstimatedArrivalTime { get; }
        DateTime TimeStamp { get; }
    }
}