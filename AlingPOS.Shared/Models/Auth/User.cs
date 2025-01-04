
namespace AlingPOS.Shared.Models.Auth
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[] Password { get; set; } = Array.Empty<byte>();
        public byte[] ConfirmPassword { get; set; } = Array.Empty<byte>();
        public UserRole Role { get; set; }
        public string VerificationToken { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTime RefreshTokenCreatedAt { get; set; } 
        public DateTime RefreshTokenExpiresAt { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
