using System;

namespace TFLDataReader.Data
{
    [Flags]
    public enum ReturnList
    {
        StopPointName = 0x01,
        StopID = 0x02,
        StopCode1 = 0x04,
        StopCode2 = 0x08,
        StopPointState = 0x10,
        StopPointType = 0x20,
        StopPointIndicator = 0x40,
        Towards = 0x80,
        Bearing = 0x100,
        Latitude = 0x200,
        Longitude = 0x400,
        VisitNumber = 0x800,
        TripID = 0x1000,
        VehicleID = 0x2000,
        RegistrationNumber = 0x4000,
        LineID = 0x8000,
        LineName = 0x10000,
        DirectionID = 0x20000,
        DestinationText = 0x40000,
        DestinationName = 0x80000,
        EstimatedTime = 0x100000,
        MessageUUID = 0x200000,
        MessageText = 0x400000,
        MessageType = 0x800000,
        MessagePriority = 0x1000000,
        StartTime = 0x2000000,
        ExpireTime = 0x4000000,
        BaseVersion = 0x8000000
    }
}
