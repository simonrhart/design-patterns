using System.Collections.Generic;
using System.Collections.ObjectModel;
using Hitachi.MVVM.Data.Spec;
using Hitachi.MVVM.Domain;
using NHibernate.Criterion;

namespace Hitachi.MVVM.Data
{
    public class CustomerRepository : Repository, ICustomerRepository
    {
        public ObservableCollection<Customer> FindAll()
        {
            return FindAll<Customer>();

           //Customer cust = new Customer();
           // cust.FirstName = "Polly";
           // cust.LastName = "Hart";
           // Session.SaveOrUpdate(cust);

           // //using (var session = factory.OpenSession())
           // //{
           // //    using (var transaction = session.BeginTransaction())
           // //    {

           // //        Customer customer = new Customer();

           // //        customer.FirstName = "simon4";
           // //        customer.LastName = "hart";

           // //        Order order1 = new Order();
           // //        order1.Customer = customer;

           // //        session.SaveOrUpdate(customer);
           // //        session.SaveOrUpdate(order1);

           // //        transaction.Commit();
                 
           // //    }
           // //}
     

           // //using (var factory = new RepositoryFactory())
           // //{

           // //    var custmer = session.Get<Customer>(19);

           // //    IList<Order> orders = custmer.Orders;

           // //    Order neworder = new Order();
           // //    orders.Add(neworder);
           // //    session.Flush();
              
           // //}
         

           // //return new ObservableCollection<customers>(););
           // return new ObservableCollection<Customer>
           //            {
           //                new Customer {FirstName = "Simon", Id = 1, LastName = "Hart"},
           //                new Customer {FirstName = "Joe", Id = 2, LastName = "Bloggs"}
           //            };

          
        }

     
    }

    public class MyClass
    {
        public void F()
        {
            
        }
    }
}
