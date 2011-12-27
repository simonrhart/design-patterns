using System.Collections.ObjectModel;
using System.Windows;
using Hitachi.MVVM.Data;
using Hitachi.MVVM.Domain;
using Hitachi.MVVM.Services;
using Hitachi.MVVM.ViewModel;
using Microsoft.Practices.Unity;

namespace Hitachi.MVVM.Views
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private readonly IMainWindowViewModel _vm;
        
        public MainWindow(IMainWindowViewModel vm)
        {
            _vm = vm;
            DataContext = _vm;
            InitializeComponent();
          
        }

    }
}
