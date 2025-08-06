namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Cellphone { get; set; }

        public string Role { get; set; } = "User";
        public bool IsAdmin { get; set; } = false;
        public string? Password { get; set; }
        public string? Username { get; set; }
    }
}
