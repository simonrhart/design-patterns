using System.Collections.ObjectModel;
using Hitachi.MVVM.Data.Spec;

namespace Hitachi.MVVM.Data
{
    public class Repository : IRepository
    {
        #region IRepository Members

        public NHibernate.ISession Session
        {
            get; set;
        }

        public ObservableCollection<TEntity> FindAll<TEntity>() where TEntity : class
        {
            var criteria = Session.CreateCriteria<TEntity>();
            var entities = criteria.List();

            var coll = new ObservableCollection<TEntity>();
            foreach (TEntity entity in entities)
                coll.Add(entity);

            return coll;
        }

        #endregion
    }
}
