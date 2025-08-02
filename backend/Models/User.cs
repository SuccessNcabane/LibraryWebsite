namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Cellphone { get; set; }

        public string Role { get; set; } = "User"; // Default role is User
        public bool IsAdmin { get; set; } = false; // Default is not an admin
    }
}
