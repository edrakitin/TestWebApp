using Microsoft.EntityFrameworkCore;
using TestWebApp.DBLayer.Models;

namespace TestWebApp.DBLayer.Contexts
{
    public class TestDbContext : DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<FileStore> FileStores { get; set; }
        public DbSet<Director> Directors { get; set; }

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
