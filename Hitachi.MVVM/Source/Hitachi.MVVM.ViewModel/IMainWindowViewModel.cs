using System.Collections.ObjectModel;
using System.Windows.Input;
using Hitachi.MVVM.Domain;

namespace Hitachi.MVVM.ViewModel
{
    public interface IMainWindowViewModel
    {
        ObservableCollection<Customer> Customers { get; set; }

        ICommand FindAllCustomersCommand { get; set; }

        string CustomerId { get; set; }
    }
}
