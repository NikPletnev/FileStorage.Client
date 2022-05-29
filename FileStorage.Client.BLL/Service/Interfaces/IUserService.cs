namespace FileStorage.Client.BLL.Service
{
    public interface IUserService
    {
        Task<string> LoginUser(string Name, string Password);
    }
}