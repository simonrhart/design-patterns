using System.Collections.ObjectModel;
using NHibernate;

namespace Hitachi.MVVM.Data.Spec
{
    public interface IRepository
    {
        ISession Session { get; set; }

        ObservableCollection<TEntity> FindAll<TEntity>() where TEntity : class;
    }
}
