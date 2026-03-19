//using Microsoft.AspNetCore.Identity;
using UsersForum.Core.Models;
using dal = UsersForum.DAL;

namespace UsersForum.Core.Users
{
    public interface IUserService
    {
        Task<bool> FindUserByUsernameAsync(string usrname);

       // void AddUser(User user);
        Task<dal.Entities.User?> UserLoginInfo(UserLogin userLogin);   
        Task<bool> UserLogOutInfo(User usr);
        Task<string> Register(User user);


    }
}
