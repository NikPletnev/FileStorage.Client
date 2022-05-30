using FileStorageClient.UI.Models;
using FileStorageClient.UI.ViewModels;
using System.Collections.ObjectModel;

namespace FileStorageClient.UI.Commands.UserStorageCommands
{
    public class DeleteFileCommand : CommandBase
    {
        private WindowUserStorageViewModel _viewModel;
        public DeleteFileCommand(WindowUserStorageViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async void Execute(object parameter)
        {
            await _viewModel._fileService.DeleteFilesAsync(_viewModel.SelectedStoredFile.Id, _viewModel._token);
            var result = await _viewModel._fileService.GetFilesAsync(_viewModel.UserId, _viewModel._token);
            _viewModel.Files = new ObservableCollection<Models.StoredFile>();
            foreach (var file in result)
            {
                _viewModel.Files.Add(_viewModel._map.Map<StoredFile>(file));
            }
        }
    }
}
