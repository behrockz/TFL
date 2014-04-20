using System;
using System.Globalization;
using NUnit.Framework;
using TFLDataReader.Data;

namespace TFLDataReaderTest.Data
{
    [TestFixture]
    public class TflEstimatedBusArrivalTimeRawDataTest
    {
        [Test]
        public void InitializeTest1()
        {
            var now = DateTime.Now;
            const string stopName = "\"Anerley Hill / Crystal Palace\"";
            const string latitude = "51.419792";
            const string longitude = "-0.077734";
            const string busName = "\"410\"";
            const string direction = "2";
            const string vehicleRegistrationNumber = "\"LJ56ARO\"";
            const string estimatedArrivalTime = "1397848843000";
            var record = new[]
                {
                    "1",
                    "[" + stopName + "]",
                    "[" + latitude + "]",
                    "[" + longitude + "]",
                    "[" + busName + "]",
                    "[" + direction + "]",
                    "[" + vehicleRegistrationNumber + "]",
                    "[" + estimatedArrivalTime + "]"
                };

            var t = new TflEstimatedBusArrivalTimeRawData();
            t.Initialize(record, now);

            Assert.AreEqual(stopName, t.StopName);
            Assert.AreEqual(latitude, t.Latitude.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(longitude, t.Longitude.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(busName, t.BusName);
            Assert.AreEqual(direction, t.Direction.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual(vehicleRegistrationNumber, t.VehicleRegistrationNumber);
            Assert.AreEqual(Convert.ToDateTime("18/04/2014 19:20:43"), t.EstimatedArrivalTime);
            Assert.AreEqual(now, t.TimeStamp);
        }

        [Test, ExpectedException(typeof(IndexOutOfRangeException))]
        public void InitializeTest2()
        {
            var now = DateTime.Now;
            const string stopName = "\"Anerley Hill / Crystal Palace\"";
            const string latitude = "51.419792";
            const string longitude = "-0.077734";
            const string busName = "\"410\"";
            const string direction = "2";
            const string vehicleRegistrationNumber = "\"LJ56ARO\"";
            var record = new[]
                {
                    "1",
                    "[" + stopName + "]",
                    "[" + latitude + "]",
                    "[" + longitude + "]",
                    "[" + busName + "]",
                    "[" + direction + "]",
                    "[" + vehicleRegistrationNumber + "]"
                };

            var t = new TflEstimatedBusArrivalTimeRawData();
            t.Initialize(record, now);
        }
    }
}
