using System;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    interface IGitHubApiService
    {
        Repository[] SearchForRepositories(string languageName, DateTime dateTime);
        Repository[] TrendingRepositories();
        User[] TrendingDevelopers();
    }
}