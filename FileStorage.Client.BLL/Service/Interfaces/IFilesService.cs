using FileStorage.Client.BLL.Models;

namespace FileStorage.Client.BLL.Service
{
    public interface IFilesService
    {
        Task UploadFile(string path, int userId, string token);
        Task DeleteFilesAsync(int fileId, string token);
        Task DownloadFile(string path, int fileId, string token);
        Task<IEnumerable<StoredFileModel>> GetFilesAsync(int userId, string token);
    }
}