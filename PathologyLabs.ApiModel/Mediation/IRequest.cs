namespace PathologyLabs.Model.Mediation
{
    public interface IRequest : IBaseRequest
    {
    }

    public interface IRequest<out TResponse> : IBaseRequest where TResponse : class
    {
    }

    public interface IBaseRequest
    {
    }
}