using AutoMapper;
using FileStorage.Client.BLL.Config;
using FileStorage.Client.BLL.Service;
using FileStorageClient.UI.Commands.MainWindowCommands;
using FileStorageClient.UI.Commands.UserStorageCommands;
using FileStorageClient.UI.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileStorageClient.UI.ViewModels
{
    public class WindowUserStorageViewModel : BaseViewModel
    {
        public readonly IFilesService _fileService;
        public readonly IUserService _userService;
        public readonly IMapper _map;
        public readonly string _token;

        public int UserId { get; set; }
        private const string USER_DATA_CLAIM = "http://schemas.microsoft.com/ws/2008/06/identity/claims/userdata";
     
        private StoredFile _selectedStoredFile;

        public StoredFile SelectedStoredFile
        {
            get { return _selectedStoredFile; }
            set
            {
                _selectedStoredFile = value;
                OnPropertyChanged(nameof(SelectedStoredFile));
            }
        }

        private ObservableCollection<StoredFile> _files;
        public ObservableCollection<StoredFile> Files
        {
            get { return _files; }
            set
            {
                _files = value;
                OnPropertyChanged(nameof(Files));
            }
        }

        private string _userNameLabel;
        public string UserNameLabel
        {
            get { return _userNameLabel; }
            set
            {
                _userNameLabel = value;
                OnPropertyChanged(nameof(UserNameLabel));
            }
        }

        private string _downloadPath;
        public string DownloadPath
        {
            get { return _downloadPath; }
            set
            {
                _downloadPath = value;
                OnPropertyChanged(nameof(DownloadPath));
            }
        }

        private string _uploadPath;
        public string UploadPath
        {
            get { return _uploadPath; }
            set
            {
                _uploadPath = value;
                OnPropertyChanged(nameof(UploadPath));
            }
        }

        public WindowUserStorageViewModel(string token)
        {
            DecodeJwtToken(token);
            _token = token;
            _fileService = new FilesService();
            _userService = new UserService();
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile(new BusinessMapper());
            });
            _map = new Mapper(config);
            LoadFiles = new LoadFilesCommand(this);
            GetUserName = new GetUserNameCommand(this);
            DeleteFile = new DeleteFileCommand(this);
            DownloadFile = new DownloadCommand(this);
            UploadFile = new UploadCommand(this);
        }

        private void DecodeJwtToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            UserId = Int32.Parse(jwtSecurityToken.Claims.First(c => c.Type == USER_DATA_CLAIM).Value);
        }

        public ICommand LoadFiles { get; set; }
        public ICommand GetUserName { get; set; }
        public ICommand DeleteFile { get; set; }
        public ICommand DownloadFile { get; set; }
        public ICommand UploadFile { get; set; }
    }
}
