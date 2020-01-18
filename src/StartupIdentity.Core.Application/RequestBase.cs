using MediatR;
using ModelWrapper;

namespace StartupIdentity.Core.Application
{
    public abstract class RequestBase<TEntity, TResponse> : WrapRequest<TEntity>, IRequest<TResponse>
        where TEntity : class
        where TResponse : ResponseBase<TEntity>
    {
    }
}
