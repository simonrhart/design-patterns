using System.Windows;
using Hitachi.MVVM.Data;
using Hitachi.MVVM.Data.Spec;
using Hitachi.MVVM.Framework.ServiceLocation;
using Hitachi.MVVM.ViewModel;
using Microsoft.Practices.Unity;

namespace Hitachi.MVVM.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IUnityContainer _container;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            _container = new UnityContainer();

            //wire up service locator.
            var unityServiceLocator = new UnityServiceLocator(_container);
            ServiceLocator.SetLocatorProvider(() => unityServiceLocator);
            _container.RegisterInstance(ServiceLocator.Current);
            _container.RegisterType<IMainWindowViewModel, MainWindowViewModel>();
            _container.RegisterType<ICustomerRepository, CustomerRepository>();
            _container.RegisterType<IRepositoryFactory, RepositoryFactory>();
            var window = _container.Resolve<MainWindow>();
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _container.Dispose();
            base.OnExit(e);
        }
    }
}
