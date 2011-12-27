using System;
using System.Threading;
using Hitachi.MVVM.Framework;
using NHibernate.Event.Default;

namespace Hitachi.MVVM.Data
{
    public class PersistenceCreateUpdateEventListener : DefaultSaveEventListener 
    {
        protected override object PerformSaveOrUpdate(NHibernate.Event.SaveOrUpdateEvent evt)
        {
            var auditable = evt.Entity as IAuditable;
            var entity = evt.Entity as IEntity;
           
            if (auditable != null && entity != null)
            {
                var principle = Thread.CurrentPrincipal;
                if (entity.IsTransient)
                {
                    auditable.CreatedOn = DateTime.Now;
                    auditable.CreatedBy = principle.Identity.Name;
                }
                auditable.ChangedOn = DateTime.Now;
                auditable.ChangedBy = principle.Identity.Name;
            }
            return base.PerformSaveOrUpdate(evt);
        }
    }
}
