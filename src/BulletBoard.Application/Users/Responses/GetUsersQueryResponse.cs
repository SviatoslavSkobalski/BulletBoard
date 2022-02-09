using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Responses
{
    public class GetUsersQueryResponse
    {
        public GetUsersQueryResponse(IEnumerable<User> users)
        {
            Users = users;
        }

        public IEnumerable<User> Users { get; }
    }
}
