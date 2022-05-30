using FileStorage.Client.BLL.Models;

namespace FileStorage.Client.BLL.Service
{
    public interface IUserService
    {
        Task<UserModel> GetUser(int userId, string token);
        Task<string> LoginUser(string Name, string Password);
    }
}