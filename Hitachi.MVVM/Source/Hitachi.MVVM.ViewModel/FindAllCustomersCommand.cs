using System;
using System.Windows.Input;
using Hitachi.MVVM.Data.Spec;
using Hitachi.MVVM.Framework.ServiceLocation;

namespace Hitachi.MVVM.ViewModel
{
    public class FindAllCustomersCommand : ICommand
    {
        private readonly IMainWindowViewModel _vm;
        private readonly IServiceLocator _serviceLocator;

        public FindAllCustomersCommand(IMainWindowViewModel vm, IServiceLocator serviceLocator)
        {
            _vm = vm;
            _serviceLocator = serviceLocator;
        }

        #region ICommand Members

        public bool CanExecute(object parameter)
        {
            //    return !string.IsNullOrEmpty(_vm.CustomerId);
            return true;
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public void Execute(object parameter)
        {
            using (var factory = _serviceLocator.GetInstance<IRepositoryFactory>())
            {
                var customerRepository = factory.Create<ICustomerRepository>();
                _vm.Customers = customerRepository.FindAll();
            }
     
        }

        #endregion
    }
}
