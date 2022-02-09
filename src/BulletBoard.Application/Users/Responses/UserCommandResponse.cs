using BulletBoard.Application.Base;
using BulletBoard.Core.Entities;

namespace BulletBoard.Application.Users.Responses
{
    public class UserCommandResponse : IResponse
    {
        public UserCommandResponse(User user)
        {
            Response = user;
        }
        public object Response { get; }
    }
}
