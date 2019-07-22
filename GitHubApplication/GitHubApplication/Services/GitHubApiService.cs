using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using GitHubApplication.Models;
using System.Collections.Generic;

namespace GitHubApplication.Services
{
    public class GitHubApiService : IGitHubApiService
    {
        public Repository[] SearchForRepositories(string languageName, DateTime dateTime)
        {
            if (dateTime == null || dateTime == DateTime.Now)
                dateTime = DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0));

            languageName = languageName == "c++" || languageName == "C++" ? "c%2b%2b" : languageName;
            languageName = languageName == "c#" || languageName == "C#" ? "c%23" : languageName;

            string generatedUrl = "https://api.github.com/search/repositories?q=created:>"
                + dateTime.ToString("yyyy-MM-dd") + "+language:" + languageName + "+&sort=stars&order=desc";

            var repositoriesRootObject = GetObjectAsync<RepositoriesRootObject>(generatedUrl).Result;
            return GetRepositories(repositoriesRootObject);
        }

        public Repository[] TrendingRepositories()
        {
            string defaultDate = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0)).ToString("yyyy-MM-dd");
            string apiUrl = "https://api.github.com/search/repositories?q=created:>" + $"{defaultDate}+&sort=stars&order=desc";

            var repositoriesRootObject = GetObjectAsync<RepositoriesRootObject>(apiUrl).Result;

            return GetRepositories(repositoriesRootObject);
        }

        private Repository[] GetRepositories(RepositoriesRootObject repositoriesRootObject)
        {
            return repositoriesRootObject.Items
                .Select(i =>
                {
                    return new Repository()
                    {
                        Name = i.name,
                        LanguageName = i.language,
                        CreatedDate = i.created_at,
                        StarCount = i.stargazers_count,
                        ForkCount = i.forks_count,
                        Description = i.description
                    };
                }).ToArray();
        }

        public User[] TrendingDevelopers()
        {
            string apiUrl = "https://api.github.com/search/users?q=+followers:%3E0&sort=followers&order=desc";

            UsersRootObject usersRootObject = GetObjectAsync<UsersRootObject>(apiUrl).Result;
            IEnumerable<string> userUrls = usersRootObject.Items.Select(u => u.url);
            IEnumerable<Task<UserFromApi>> usersFromApi = userUrls.Select(url => GetObjectAsync<UserFromApi>(url));

            return usersFromApi.Select(u =>
            {
                return new User()
                {
                    UserName = u.Result.login,
                    Name = u.Result.name,
                    Bio = u.Result.bio?.ToString(),
                    Email = u.Result.email?.ToString(),
                    Location = u.Result.location?.ToString()
                };
            }).ToArray();
        }

        private Task<T> GetObjectAsync<T>(string url)
        {
            return Task.Run(() =>
            {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.UserAgent = "My request";

                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string JsonString = reader.ReadToEnd();

                return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(JsonString);
            });
        }
    }
}