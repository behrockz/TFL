using System.Collections.Generic;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using TFLDataReader.Data;

namespace TFLDataReader.Parser
{
    internal class TflResponseParser<T> : ITflResponseParser<T> where T : ITflRawData, new()
    {
        private readonly CsvFactory csvfactory;
        private readonly CsvConfiguration csvConfiguration;
        private readonly IRawRecordParser<T> parser;

        public TflResponseParser(IRawRecordParser<T> parser)
        {
            this.parser = parser;
            csvfactory = new CsvFactory();
            csvConfiguration = new CsvConfiguration {HasHeaderRecord = false, WillThrowOnMissingField = false};
        }

        public IEnumerable<T> ParsContent(string content)
        {
            var reader = csvfactory.CreateReader(new StringReader(content), csvConfiguration);
            reader.Read();
            var header = reader.CurrentRecord;

            var timeStamp = ParserUtility.ConvertUnixTimeToDateTime(header[2]);

            while (reader.Read())
            {
                yield return parser.Parse(reader.CurrentRecord, timeStamp);
            }
        }
    }
}
