using TestWebApp.BusinessLogicLayer.Repositories.Interfaces;
using TestWebApp.BusinessLogicLayer.Repositories.Realizations;
using TestWebApp.DBLayer.Models;

namespace TestWebApp.BusinessLogicLayer.Services
{
    public class RepositoryService
    {
        public RepositoryService(IUnitOfWork unitOfWork)
        {
            IRepository<Film> filmRepository = new Repository<Film>(unitOfWork);
            FilmService = new DbService<Film>(filmRepository);
            IRepository<FileStore> fileStoreRepository = new Repository<FileStore>(unitOfWork);
            FileStoreService = new DbService<FileStore>(fileStoreRepository);
            IRepository<Director> directorRepository = new Repository<Director>(unitOfWork);
            DirectorService = new DbService<Director>(directorRepository);
        }

        public DbService<Film> FilmService { get; }
        public DbService<FileStore> FileStoreService { get; }
        public DbService<Director> DirectorService { get; }
    }
}
