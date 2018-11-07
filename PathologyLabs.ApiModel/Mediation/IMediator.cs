using System;
using PathologyLabs.Model.Mediation;

namespace PathologyLabs.Model.Core
{
    public interface IMediator<TRequest> where TRequest : IBaseRequest, IRequest
    {

    }

    public interface IMediator<TRequest, TResponse> 
        where TRequest : IRequest<TResponse>
        where TResponse : IEquatable<TResponse>, IComparable<TResponse>
    {
        TResponse Send();
    }
}
