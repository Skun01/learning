namespace Domain.Entities;

public class RefreshToken : BaseEntity
{
    public string UserId { set; get; } = null!;
    public string Token { set; get; } = string.Empty;
    public bool Revoked { set; get; }
    public DateTime ExpiresAt { set; get; }

    public User User { set; get; } = null!;
}
