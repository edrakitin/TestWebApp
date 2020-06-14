using System;
using TestWebApp.DBLayer.Contexts;

namespace TestWebApp.BusinessLogicLayer.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        TestDbContext Context { get; }
        void Commit();
    }
}
