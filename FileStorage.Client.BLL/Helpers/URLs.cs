using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.Client.BLL.Helpers
{
    public static class Urls
    {
        public const string Domain = "https://localhost:5001/";
        public const string Login = "api/Auth/login";
        public const string GetFiles = "api/User/";
        public const string GetUser = "api/User/";
        public const string DeleteFile = "api/StoragedFile/";
        public const string GetFile = "api/StoragedFile/";
        public const string UploadFile = "api/StoragedFile";
    }
}
