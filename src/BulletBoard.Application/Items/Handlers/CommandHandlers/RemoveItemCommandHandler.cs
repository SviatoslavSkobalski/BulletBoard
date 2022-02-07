using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Commands;
using BulletBoard.Application.Items.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Items.Handlers.CommandHandlers
{
    internal class RemoveItemCommandHandler : ICommandHandler<RemoveItemCommand>
    {
        private readonly ItemsRepository _itemsRepository;

        public RemoveItemCommandHandler(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public async Task<IResponse> Handle(RemoveItemCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _itemsRepository.DeleteAsync(request.item);

            return new ItemCommandResponse(response);
        }
    }
}
