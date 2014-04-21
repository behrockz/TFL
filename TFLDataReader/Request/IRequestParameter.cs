namespace TFLDataReader.Request
{
    public interface IRequestParameter
    {
        object Value { get; }
        string Name { get; }
    }
}
