using FluentNHibernate.Mapping;
using Hitachi.MVVM.Domain;

namespace Hitachi.MVVM.Data.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(x => x.Id, "CustomerId");
            Schema("dbo");
            Table("Customers");
            //one to many
            HasMany(x => x.Orders)
              .KeyColumn("CustomerId")
              .Cascade.All();

            Map(x => x.FirstName, "FirstName");
            Map(x => x.LastName, "LastName");
            Map(x => x.ChangedBy, "ChangedBy");
            Map(x => x.ChangedOn, "ChangedOn");
            Map(x => x.CreatedBy, "CreatedBy");
            Map(x => x.CreatedOn);
        }
    }
}
