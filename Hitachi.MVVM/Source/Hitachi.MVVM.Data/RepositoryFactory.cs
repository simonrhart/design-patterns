using System;
using System.Security;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Hitachi.MVVM.Data.Spec;
using Hitachi.MVVM.Framework.ServiceLocation;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Event;

namespace Hitachi.MVVM.Data
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly ISessionFactory _sessionFactory;
        private readonly ISession _session;
        private bool _disposed;

        public RepositoryFactory(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
            //setup the event listeners - improved interceptors.
            var cfg = new Configuration();
            cfg.EventListeners.SaveOrUpdateEventListeners = new ISaveOrUpdateEventListener[] { new PersistenceCreateUpdateEventListener() };

            _sessionFactory = Fluently.Configure(cfg)
                .Database(MsSqlConfiguration.MsSql2005.ConnectionString(
                c => c
                    .Server("ESLPC410")
                    .Database("MVVM")
                    .Password("")
                    .Username("sa")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Repository>())
                .BuildSessionFactory();
            _session = _sessionFactory.OpenSession();
        }

        public void Flush()
        {
            _session.Flush();
        }

        public TRepository Create<TRepository>() where TRepository : IRepository
        {
            var repository = _serviceLocator.GetInstance<TRepository>();
            repository.Session = _session;
            return repository;
        }

        #region IDisposable Members

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_sessionFactory != null)
                    {
                        _session.Close();
                        _sessionFactory.Close();
                        _sessionFactory.Dispose();
                    }
                }
                _disposed = true;
            }
        }
    }
}
