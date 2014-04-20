using System;

namespace TFLDataReader.Parser
{
    internal static class ParserUtility
    {
        public static DateTime ConvertUnixTimeToDateTime(string unixTime)
        {
            return ConvertUnixTimeToDateTime(Convert.ToInt64(Trim(unixTime)));
        }

        public static DateTime ConvertUnixTimeToDateTime(long unixTime)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
            return epoch.AddMilliseconds(unixTime);
        }

        public static string Trim(string s)
        {
            return s.Trim("[]".ToCharArray());
        }
    }
}
