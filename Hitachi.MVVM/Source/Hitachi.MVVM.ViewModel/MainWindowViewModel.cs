using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Hitachi.MVVM.Domain;
using Hitachi.MVVM.Data.Spec;
using Hitachi.MVVM.Framework.ServiceLocation;

namespace Hitachi.MVVM.ViewModel
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IServiceLocator _serviceLocator;
        public ICommand FindAllCustomersCommand { get; set; }
        private ObservableCollection<Customer> customers = new ObservableCollection<Customer>();
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return customers;
            }
            set
            {
                customers.Clear();
                foreach(var customer in value)
                    customers.Add(customer);
            }
        }

        public MainWindowViewModel(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;

            Customers = new ObservableCollection<Customer>();
            
            FindAllCustomersCommand = new FindAllCustomersCommand(this, _serviceLocator);
        }

      
        public string CustomerId { get; set; }
    }
}
