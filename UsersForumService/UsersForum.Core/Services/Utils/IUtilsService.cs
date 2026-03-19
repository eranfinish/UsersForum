using dal = UsersForum.DAL;
using UsersForum.Core.Models;

namespace UsersForum.Core.Utils
{
    public interface IUtilsService
    {
        void DbUser2User(dal.Entities.User dbUser, User user);
        void User2dbUser(User user, dal.Entities.User dbUser);



    }
}
