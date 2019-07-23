using System.Collections.Generic;



namespace GitHub.Core.Dtos
{
    public class UsersRootObject
    {
        public int total_count { get; set; }
        public bool incomplete_results { get; set; }
        public List<UsersFromApi> Items { get; set; }
    }
}