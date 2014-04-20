using RestSharp;
using TFLDataReader.Data;

namespace TFLDataReader.Request
{
    public interface ITflRequest
    {
        RestRequest GetRequest(ReturnList returnList);
    }
}