using System;

namespace Hitachi.MVVM.Data.Spec
{
    public interface IRepositoryFactory : IDisposable
    {
        TRepository Create<TRepository>() where TRepository : IRepository;

        void Flush();
    }
}
