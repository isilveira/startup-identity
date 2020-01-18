using MediatR;
using ModelWrapper;

namespace StartupIdentity.Core.Application
{
    public abstract class ResponseBase<TEntity> : WrapResponse<TEntity>
        where TEntity : class
    {
    }
}
