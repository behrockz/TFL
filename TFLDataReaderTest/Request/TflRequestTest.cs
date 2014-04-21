using System;
using NUnit.Framework;
using TFLDataReader.Data;
using TFLDataReader.Request;

namespace TFLDataReaderTest.Request
{
    [TestFixture]
    public class TflRequestTest
    {
        [Test]
        public void GetRequest()
        {
            const ReturnList returnList = ReturnList.BaseVersion |
                                          ReturnList.Bearing |
                                          ReturnList.DestinationName |
                                          ReturnList.DestinationText |
                                          ReturnList.DirectionID |
                                          ReturnList.EstimatedTime |
                                          ReturnList.ExpireTime |
                                          ReturnList.Latitude |
                                          ReturnList.LineID |
                                          ReturnList.LineName |
                                          ReturnList.Longitude |
                                          ReturnList.MessagePriority |
                                          ReturnList.MessageText |
                                          ReturnList.MessageType |
                                          ReturnList.MessageUUID |
                                          ReturnList.RegistrationNumber |
                                          ReturnList.StartTime |
                                          ReturnList.StopCode1 |
                                          ReturnList.StopCode2 |
                                          ReturnList.StopID |
                                          ReturnList.StopPointIndicator |
                                          ReturnList.StopPointName |
                                          ReturnList.StopPointState |
                                          ReturnList.StopPointType |
                                          ReturnList.Towards |
                                          ReturnList.TripID |
                                          ReturnList.VehicleID |
                                          ReturnList.VisitNumber;

            var req = new TflRequest(new FilterParameter(returnList));

            var restReq = req.GetRequest();
            var enumType = typeof (ReturnList);

            foreach (var s in ((string)restReq.Parameters[0].Value).Split(",".ToCharArray()))
            {
                var value = Enum.Parse(enumType, s);
                if (!Enum.IsDefined(enumType, value))
                {
                    Assert.Fail();
                }
            }

            foreach (var enumName in Enum.GetNames(enumType))
            {
                if(!((string)restReq.Parameters[0].Value).Contains(enumName))
                {
                    Assert.Fail();
                }
            }

            Assert.AreEqual("ReturnList", restReq.Parameters[0].Name);
        }
    }
}
