using FileStorageClient.UI.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace FileStorageClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            if (_viewModel.CloseAction == null)
                _viewModel.CloseAction = new Action(this.Close);
            DataContext = _viewModel;
        }
        void PasswordChangedHandler(Object sender, RoutedEventArgs args)
        {
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext).SecurePassword = ((PasswordBox)sender).SecurePassword;
            }
        }

    }
}
