using Microsoft.Practices.Unity;
using NUnit.Framework;
using TFLDataReader.Client;
using TFLDataReader.Data;

namespace TFLDataReaderTest
{
    [TestFixture]
    public class TflClientGenericDependencyRegisterTest
    {
        [Test]
        public void RegisterTestWithStub()
        {
            using (var container = new UnityContainer())
            {
                new TflClientGenericDependencyRegister<TestTflRawDataStub>().Register(container);
                var client = container.Resolve<ITflClient<TestTflRawDataStub>>();

                Assert.NotNull(client);
            }
        }

        [Test]
        public void RegisterTestWithTflEstimatedBusArrivalTimeRawData()
        {
            using (var container = new UnityContainer())
            {
                new TflClientGenericDependencyRegister<TflEstimatedBusArrivalTimeRawData>().Register(container);
                var client = container.Resolve<ITflClient<TflEstimatedBusArrivalTimeRawData>>();

                Assert.NotNull(client);
            }
        }
    }
}
