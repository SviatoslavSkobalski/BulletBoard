using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Responses
{
    public class GetUserQueryResponse
    {
        public GetUserQueryResponse(User user)
        {
            User = user;
        }

        public User User { get; }
    }
}
