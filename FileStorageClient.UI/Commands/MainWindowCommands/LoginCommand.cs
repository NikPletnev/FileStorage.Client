using FileStorageClient.UI.Helpers;
using FileStorageClient.UI.ViewModels;
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
