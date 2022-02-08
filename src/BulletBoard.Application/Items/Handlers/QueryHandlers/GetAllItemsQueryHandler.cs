using BulletBoard.Application.Base;
using BulletBoard.Application.Items.Queries;
using BulletBoard.Application.Items.Responses;
using BulletBoard.Infrastructure.Repositories;

namespace BulletBoard.Application.Items.Handlers.QueryHandlers
{
    public class GetAllItemsQueryHandler : IQueryHandler<GetAllItemsQuery, GetAllItemsResponse>
    {
        private readonly ItemsRepository _itemsRepository;

        public GetAllItemsQueryHandler(ItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }
        public async Task<GetAllItemsResponse> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var result = await _itemsRepository.GetAllAsync();

            return new GetAllItemsResponse(result);
        }
    }
}
