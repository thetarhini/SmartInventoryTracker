namespace SIT.API.Models.Auth
{
    public class AuthResponse
    {
        public string? Token { get; set; }
        public string? Username { get; set; }
        public string? Role { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}