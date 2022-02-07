using MediatR;

namespace BulletBoard.Application.Base
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, IResponse> where TCommand : ICommand
    {
    }
}
