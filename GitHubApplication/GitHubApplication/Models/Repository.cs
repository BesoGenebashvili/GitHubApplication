using System;

namespace GitHubApplication.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string LanguageName { get; set; }
        public int StarCount { get; set; }
        public int ForkCount { get; set; }
    }
}