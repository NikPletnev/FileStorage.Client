using FileStorageClient.UI.ViewModels;

namespace FileStorageClient.UI.Commands.UserStorageCommands
{
    public class GetUserNameCommand : CommandBase
    {
        private WindowUserStorageViewModel _viewModel;
        public GetUserNameCommand(WindowUserStorageViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async void Execute(object parameter)
        {
            var result = await _viewModel._userService.GetUser(_viewModel.UserId, _viewModel._token);
            _viewModel.UserNameLabel = "Hello " + result.Name;
        }
    }
}
