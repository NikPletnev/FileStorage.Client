using AutoMapper;
using FileStorage.Client.BLL.Models;
using FileStorageClient.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorage.Client.BLL.Config
{
    public class BusinessMapper : Profile
    {
        public BusinessMapper()
        {
            CreateMap<User, UserModel>();
            CreateMap<UserModel, User>();

            CreateMap<StoredFile, StoredFileModel>();
            CreateMap<StoredFileModel, StoredFile>();

        }

    }
}
