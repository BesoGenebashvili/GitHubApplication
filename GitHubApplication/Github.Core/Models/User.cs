namespace GitHub.Core.Models
{
    public class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string Bio { get; set; }
        public string Interest { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }

        public int Id { get; set; }
    }
}