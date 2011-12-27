using System.Collections.Generic;
using Hitachi.MVVM.Framework;

namespace Hitachi.MVVM.Domain
{
    public class Customer : Entity
    {
        public virtual string FirstName
        {
            get; set;
        }

        public virtual string LastName
        {
            get; set;
        }

        public virtual IList<Order> Orders { get; set; }
    }
}
