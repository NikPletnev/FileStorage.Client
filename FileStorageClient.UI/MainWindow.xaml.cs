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
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;
            InitializeComponent();
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
