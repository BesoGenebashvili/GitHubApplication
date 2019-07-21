using System;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IGitHubApiService
    {
        Repository[] SearchForRepositories(string languageName, DateTime dateTime);
        Repository[] TrendingRepositories();
        User[] TrendingDevelopers();
    }
}