using MediatR;

namespace BulletBoard.Application.Base
{
    public interface ICommand : IRequest<IResponse>, IBaseRequest
    {
    }
}
