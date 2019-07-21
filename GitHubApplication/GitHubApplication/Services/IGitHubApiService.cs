using System;
using System.Threading.Tasks;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IGitHubApiService
    {
        Repository[] SearchForRepositories(string languageName, DateTime dateTime);
        Task<Repository[]> TrendingRepositories();
        User[] TrendingDevelopers();
    }
}