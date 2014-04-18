using RestSharp;
using TFLDataReader.Data;

namespace TFLDataReader.Client
{
    public interface ITflRequest
    {
        RestRequest GetRequest(ReturnList returnList);
    }
}