using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Commands;
using BulletBoard.Application.Items.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Items.Handlers.CommandHandlers
{
    internal class UpdateItemCommandHandler : ICommandHandler<UpdateItemCommand>
    {
        private readonly ItemsRepository _itemsRepository;

        public UpdateItemCommandHandler(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public async Task<IResponse> Handle(UpdateItemCommand request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _itemsRepository.UpdateAsync(request.item);

            if (result != null)
            {
                return new ItemCommandResponse(result);
            }

            throw new ArgumentNullException(nameof(result));
        }
    }
}
