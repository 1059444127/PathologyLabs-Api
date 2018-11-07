using System.Threading.Tasks;

namespace PathologyLabs.Model.Mediation
{
    public interface IRequestHandler<in TRequest, TResponse> where TRequest : IRequest<TResponse> where TResponse : class
    {
        Task<TResponse> Handle(TRequest request);
    }

    public interface IRequestHandler<in TRequest> where TRequest : IRequest
    {
        Task Handle(TRequest request);
    }
}
