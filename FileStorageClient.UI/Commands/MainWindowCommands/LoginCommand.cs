using FileStorageClient.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageClient.UI.Commands.MainWindowCommands
{
    internal class LoginCommand : CommandBase
    {
        private MainWindowViewModel _viewModel;
        public LoginCommand(MainWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {

        }
    }
}
