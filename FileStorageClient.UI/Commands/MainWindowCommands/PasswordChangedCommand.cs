using FileStorageClient.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageClient.UI.Commands.MainWindowCommands
{
    internal class PasswordChangedCommand : CommandBase
    {
        private MainWindowViewModel _viewModel;
        public PasswordChangedCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {

        }
    }
}
