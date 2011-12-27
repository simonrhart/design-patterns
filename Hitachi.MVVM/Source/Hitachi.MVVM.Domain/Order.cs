using Hitachi.MVVM.Framework;

namespace Hitachi.MVVM.Domain
{
    public class Order : Entity
    {
        public virtual Customer Customer
        {
            get; set;
        }

        public virtual int Quantity
        {
            get; set;
        }
    }
}
