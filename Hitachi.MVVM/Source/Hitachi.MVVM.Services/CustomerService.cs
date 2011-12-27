using System.Collections.Generic;
using System.Collections.ObjectModel;
using Hitachi.MVVM.Domain;
using Hitachi.MVVM.Services.Spec;

namespace Hitachi.MVVM.Services
{
    public class CustomerService : ICustomerService
    {
        #region ICustomerService Members

        public string StartAnnouncementWorkflow(string request)
        {
            return "t";
        }

        #endregion
    }
}
