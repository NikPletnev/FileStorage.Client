using RestSharp;

namespace FileStorage.Client.BLL.Service
{
    public abstract class BaseService
    {
        protected string _domain;
        protected async Task<RestResponse<T>?> GetResponseAsync<T>(RestRequest request)
        {
            var client = new RestClient(_domain);

            return await client.ExecuteAsync<T>(request);
        }

    }
}
