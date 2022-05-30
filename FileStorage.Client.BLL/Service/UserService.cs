using FileStorage.Client.BLL.Helpers;
using FileStorage.Client.BLL.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.Client.BLL.Service
{
    public class UserService : BaseService, IUserService
    {

        public UserService()
        {
            _domain = Urls.Domain;
        }
        public async Task<string> LoginUser(string name, string password)
        {
            var userModel = new UserModel() { Name = name, Password = password};
            RestRequest request = new RestRequest(Urls.Login, Method.Post);
            request.AddBody(userModel);
            var response = await GetResponseAsync<string>(request);
            var token = response.Data;
            if (token != null)
            { 
                return token;
            }
            else
            {
                return null;
            }
        }

        public async Task<UserModel> GetUser(int userId, string token)
        {
            var userIdParam = "id";
            RestRequest request = new RestRequest(Urls.GetUser + $"{userId}", Method.Get);
            request.AddParameter(userIdParam, userId);
            request.AddHeader("Authorization", "Bearer " + token);
            var response = await GetResponseAsync<UserModel>(request);
            return response.Data;
        }
    }
}
