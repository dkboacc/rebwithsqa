public class DefaultResponse: IResponse
{
    public DefaultResponse(string message)
    {
        Message = message;
    }
    public string Message{ get; private set;}
}