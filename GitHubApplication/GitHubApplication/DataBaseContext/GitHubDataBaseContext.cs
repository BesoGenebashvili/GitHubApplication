using GitHubApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.DataBaseContext
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