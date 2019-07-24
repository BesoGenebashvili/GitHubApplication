using System;
using System.Threading.Tasks;
using GitHub.Core.Models;

namespace GitHub.Core.Services.Abstractions
{
    public interface IGitHubApiService
    {
        Task<Repository[]> SearchForRepositories(string languageName, DateTime dateTime = new DateTime(), string repositoryName = "");
        Task<Repository[]> TrendingRepositories();
        Task<User[]> TrendingDevelopers();
    }
}