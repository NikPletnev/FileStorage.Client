using FileStorageClient.UI.ViewModels;
using System.Windows;

namespace FileStorageClient.UI.Windows
{
    /// <summary>
    /// Interaction logic for WindowUserStorage.xaml
    /// </summary>
    public partial class WindowUserStorage : Window
    {
        private WindowUserStorageViewModel _viewModel;
        public WindowUserStorage(string token)
        {
            InitializeComponent();
            _viewModel = new WindowUserStorageViewModel(token);
            DataContext = _viewModel;
        }
    }
}
