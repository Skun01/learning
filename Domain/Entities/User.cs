namespace Domain.Entities;

public class User : BaseEntity
{
    public string Username { set; get; } = string.Empty;
    public string Email { set; get; } = string.Empty;
    public string PasswordHash { set; get; } = string.Empty;
    public bool IsVerified { set; get; }
}
