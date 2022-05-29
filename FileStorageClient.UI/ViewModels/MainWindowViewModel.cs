using FileStorageClient.UI.Commands.MainWindowCommands;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileStorageClient.UI.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        public ICommand Login { get; set; }

        private string _nameTextBox;
        private string _passwordTextBox;
        public string NameTextBox
        {
            get { return _nameTextBox; }
            set
            {
                _nameTextBox = value;
                OnPropertyChanged(nameof(NameTextBox));
            }
        }

        public string PasswordTextBox
        {
            get { return _passwordTextBox; }
            set 
            {
                _passwordTextBox = value;
                OnPropertyChanged(nameof(PasswordTextBox));
            }
        }

        public MainWindowViewModel()
        {
            Login = new LoginCommand(this);
        }

    }
}
