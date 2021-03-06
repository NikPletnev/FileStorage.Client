using FileStorageClient.UI.Models;
using FileStorageClient.UI.ViewModels;
using System.Collections.ObjectModel;

namespace FileStorageClient.UI.Commands.UserStorageCommands
{
    public class LoadFilesCommand : CommandBase
    {
        private WindowUserStorageViewModel _viewModel;
        public LoadFilesCommand(WindowUserStorageViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async void Execute(object parameter)
        {
            var result = await _viewModel._fileService.GetFilesAsync(_viewModel.UserId, _viewModel._token);
            _viewModel.Files = new ObservableCollection<Models.StoredFile>();
            foreach (var file in result)
            {
                _viewModel.Files.Add(_viewModel._map.Map<StoredFile>(file));
            }
        }
    }
}
