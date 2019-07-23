using GitHub.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace GitHub.Core.DataBaseContext
{
    public class GitHubDataBaseContext : DbContext
    {
        public GitHubDataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=.\GitHubDataBase.db");
        }

        public DbSet<User> Users { get; set; }
    }
}