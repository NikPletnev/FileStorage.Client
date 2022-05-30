using FileStorageClient.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
