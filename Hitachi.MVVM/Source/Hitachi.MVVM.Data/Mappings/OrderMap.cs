using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Hitachi.MVVM.Domain;

namespace Hitachi.MVVM.Data.Mappings
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(x => x.Id, "OrderId");
            Schema("dbo");
            Table("Orders");
            Map(x => x.Quantity);
            References(x => x.Customer)
                .Column("CustomerId");

            Map(x => x.ChangedBy, "ChangedBy");
            Map(x => x.ChangedOn, "ChangedOn");
            Map(x => x.CreatedBy, "CreatedBy");
            Map(x => x.CreatedOn);
        }
    }
}
