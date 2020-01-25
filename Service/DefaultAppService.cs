public class DefaultAppService: IAppService
{
    IResponse Handle(IRequest request)
    {
        return new DefaultResponse("default response");
    }
}