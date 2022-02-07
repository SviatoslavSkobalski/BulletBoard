using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Queries;
using BulletBoard.Application.Items.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Items.Handlers.QueryHandlers
{
    public class GetItemQueryHandler : IQueryHandler<GetItemQuery, GetItemResponse>
    {
        private readonly ItemsRepository _itemsRepository;

        public GetItemQueryHandler(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public async Task<GetItemResponse> Handle(GetItemQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var response = await _itemsRepository.GetByIdAsync(request.id);
        
            return new GetItemResponse(response);
        }
    }
}
