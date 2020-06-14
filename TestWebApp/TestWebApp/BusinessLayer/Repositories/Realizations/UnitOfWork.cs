using TestWebApp.BusinessLogicLayer.Repositories.Interfaces;
using TestWebApp.DBLayer.Contexts;

namespace TestWebApp.BusinessLogicLayer.Repositories.Realizations
{
    public class UnitOfWork : IUnitOfWork
    {
        public TestDbContext Context { get; }

        public UnitOfWork(TestDbContext context)
        {
            Context = context;
        }
        public void Commit()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();

        }
    }
}
