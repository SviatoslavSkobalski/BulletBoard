using MediatR;

namespace BulletBoard.Application.Base
{
    internal interface IQuery<out TResponse> : IRequest<TResponse>, IBaseRequest
    {
    }
}
