using System;
using System.Windows.Input;

namespace Hitachi.MVVM.ViewModel
{
    public class GetCustomerCommand : ICommand
    {
        private readonly IMainWindowViewModel _vm;
        public GetCustomerCommand(IMainWindowViewModel vm)
        {
            _vm = vm;
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
            //to do_vm.LoadCustomers();
        }

        #endregion
    }
}
