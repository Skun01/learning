namespace Application.DTOs.Auth;

public class LoginRequest
{
    public string Email { set; get; } = string.Empty;
    public string Password { set; get; } = string.Empty;
}
