using FileStorage.Client.BLL.Service;
using FileStorageClient.UI.Commands.MainWindowCommands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileStorageClient.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public readonly IUserService _userService;
        public ICommand Login { get; set; }

        private string _nameTextBox;
        public string NameTextBox
        {
            get { return _nameTextBox; }
            set
            {
                _nameTextBox = value;
                OnPropertyChanged(nameof(NameTextBox));
            }
        }

        private string _errorLabel;
        public string ErrorLabel
        {
            get { return _errorLabel; }
            set
            {
                _errorLabel = value;
                OnPropertyChanged(nameof(ErrorLabel));
            }
        }

        public SecureString SecurePassword { get; set; }

        public MainWindowViewModel()
        {
            Login = new LoginCommand(this);
            _userService = new UserService();
        }

    }
}
