using FileStorageClient.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileStorageClient.UI.Helpers;
using FileStorageClient.UI.Windows;

namespace FileStorageClient.UI.Commands.MainWindowCommands
{
    public class LoginCommand : CommandBase
    {
        private MainWindowViewModel _viewModel;
        public LoginCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async void Execute(object parameter)
        {
            var result = await _viewModel._userService.LoginUser(_viewModel.NameTextBox, StringHelper.SecureStringToString(_viewModel.SecurePassword));
            if (result != null)
            {
                WindowUserStorage userStorageWindow = new WindowUserStorage(result);
                userStorageWindow.Show();
                _viewModel.CloseAction();
            }
            else
            {
                _viewModel.ErrorLabel = "Invalid username or Password";
            }
        }
    }
}
