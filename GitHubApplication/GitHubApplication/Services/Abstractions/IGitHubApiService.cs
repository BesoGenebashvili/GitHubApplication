using System;
using System.Threading.Tasks;
using GitHubApplication.Models;

namespace GitHubApplication.Services.Abstractions
{
    public interface IGitHubApiService
    {
        Task<Repository[]> SearchForRepositories(string languageName, DateTime dateTime);
        Task<Repository[]> TrendingRepositories();
        Task<User[]> TrendingDevelopers();
    }
}