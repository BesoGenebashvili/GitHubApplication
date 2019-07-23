using System;

namespace GitHub.Core.Models
{
    public class Repository
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LanguageName { get; set; }
        public int StarCount { get; set; }
        public int ForkCount { get; set; }
    }
}