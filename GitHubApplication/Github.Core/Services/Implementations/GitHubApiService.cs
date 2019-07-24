using System;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using GitHub.Core.Models;
using System.Collections.Generic;
using GitHub.Core.Dtos;
using GitHub.Core.Services.Abstractions;
using Github.Core.Exceptions;

namespace GitHub.Core.Services.Implementations
{
    public class GitHubApiService : IGitHubApiService
    {
        public async Task<Repository[]> SearchForRepositories(string languageName, DateTime dateTime)
        {
            if (dateTime == default || dateTime == DateTime.Now)
                dateTime = DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0));

            languageName = languageName == "c++" || languageName == "C++" ? "c%2b%2b" : languageName;
            languageName = languageName == "c#" || languageName == "C#" ? "c%23" : languageName;

            string generatedUrl = "https://api.github.com/search/repositories?q=created:>"
                + dateTime.ToString("yyyy-MM-dd") + "+language:" + languageName + "+&sort=stars&order=desc";

            var repositoriesRootObject = await GetObjectAsync<RepositoriesRootObject>(generatedUrl);
            var result = await GetRepositoriesAsync(repositoriesRootObject.Items);
            return result;
        }

        public async Task<Repository[]> TrendingRepositories()
        {
            string defaultDate = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)).ToString("yyyy-MM-dd");
            string apiUrl = "https://api.github.com/search/repositories?q=created:>" + $"{defaultDate}+&sort=stars&order=desc";

            var repositoriesRootObject = await GetObjectAsync<RepositoriesRootObject>(apiUrl);

            var result = await GetRepositoriesAsync(repositoriesRootObject.Items);
            return result;
        }

        private Task<Repository[]> GetRepositoriesAsync(IEnumerable<RepositoriesFromApi> repositoriesFromApi)
        {
            if (repositoriesFromApi == null)
            {
                throw new RepositoriesNotFoundException(nameof(repositoriesFromApi));
            }

            return Task.Run(() => repositoriesFromApi
                       .Select(i => new Repository()
                       {
                           Name = i.name,
                           LanguageName = i.language,
                           CreatedDate = i.created_at,
                           StarCount = i.stargazers_count,
                           ForkCount = i.forks_count,
                           Description = i.description
                       })
                       .ToArray());
        }

        public async Task<User[]> TrendingDevelopers()
        {
            string apiUrl = "https://api.github.com/search/users?q=+followers:%3E0&sort=followers&order=desc";

            UsersRootObject usersRootObject = await GetObjectAsync<UsersRootObject>(apiUrl);
            var usersTasks = usersRootObject.Items.Select(u => GetObjectAsync<UserFromApi>(u.url)).ToArray();

            var users = await Task.WhenAll(usersTasks);

            var result = await GetUsersAsync(users);

            return result;
        }

        private Task<User[]> GetUsersAsync(IEnumerable<UserFromApi> usersFromApi)
        {
            return Task.Run(() => usersFromApi
                       .Select(u => new User()
                       {
                           UserName = u.login,
                           Name = u.name,
                           Bio = u.bio?.ToString(),
                           Email = u.email?.ToString(),
                           Location = u.location?.ToString()
                       })
                       .ToArray());
        }

        private async Task<T> GetObjectAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("GitHub.Core", "1.0.0"));
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync(url);
                var content = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(content);
                return result;
            }
        }
    }
}