using FileStorage.Client.BLL.Helpers;
using FileStorage.Client.BLL.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.Client.BLL.Service
{
    public class FilesService : BaseService, IFilesService
    {
        public FilesService()
        {
            _domain = Urls.Domain;
        }

        public async Task<IEnumerable<StoredFileModel>> GetFilesAsync(int userId, string token)
        {
            var userIdParam = "id";
            RestRequest request = new RestRequest(Urls.GetFiles + $"{userId}/files", Method.Get);
            request.AddParameter(userIdParam, userId);
            request.AddHeader("Authorization", "Bearer " + token);
            var response = await GetResponseAsync<List<StoredFileModel>>(request);

            var files = response.Data;
            return files;
        }

        public async Task DeleteFilesAsync(int fileId, string token)
        {
            var fileIdParam = "id";
            RestRequest request = new RestRequest(Urls.DeleteFile + $"{fileId}", Method.Delete);
            request.AddParameter(fileIdParam, fileId);
            request.AddHeader("Authorization", "Bearer " + token);
            var response = await GetResponseAsync<Task>(request);
        }

        public async Task UploadFile(string path, int userId, string token)
        {
            var newFile = new StoredFileModel();
            var rawData = File.ReadAllBytes(path);
            newFile.Data = Convert.ToBase64String(rawData);
            newFile.Size = rawData.Length;
            newFile.UserId = userId;
            newFile.Name = path;

            RestRequest request = new RestRequest(Urls.UploadFile, Method.Post);
            request.AddBody(newFile);
            request.AddHeader("Authorization", "Bearer " + token);
            await GetResponseAsync<Task>(request);
        }

        public async Task DownloadFile(string path, int fileId, string token)
        {
            var fileIdParam = "id";
            RestRequest request = new RestRequest(Urls.GetFile + $"{fileId}", Method.Get);
            request.AddParameter(fileIdParam, fileId);
            request.AddHeader("Authorization", "Bearer " + token);
            var response = await GetResponseAsync<StoredFileModel>(request);
            var data = Convert.FromBase64String(response.Data.Data);
            File.WriteAllBytes(path, data);
        }
    }
}
