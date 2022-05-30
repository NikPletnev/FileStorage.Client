using FileStorageClient.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageClient.UI.Commands.UserStorageCommands
{
    public class DownloadCommand : CommandBase
    {
        private WindowUserStorageViewModel _viewModel;
        public DownloadCommand(WindowUserStorageViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override async void Execute(object parameter)
        {
            await _viewModel._fileService.DownloadFile(_viewModel.DownloadPath, _viewModel.SelectedStoredFile.Id, _viewModel._token);
        }
    }
}
