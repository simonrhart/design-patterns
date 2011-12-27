using System.Collections.ObjectModel;
using Hitachi.MVVM.Domain;

namespace Hitachi.MVVM.Data.Spec
{
    public interface ICustomerRepository : IRepository
    {
        ObservableCollection<Customer> FindAll();
    }
}
