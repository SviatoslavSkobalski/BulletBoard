using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Commands;
using BulletBoard.Application.Items.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Items.Handlers.CommandHandlers
{
    internal class CreateItemCommandHandler : ICommandHandler<CreateItemCommand>
    {
        private readonly ItemsRepository _itemsRepository;

        public CreateItemCommandHandler(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public async Task<IResponse> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _itemsRepository.AddAsync(request.Item);

            return new ItemCommandResponse(response);
        }
    }
}
