namespace Application.DTOs.Auth;

public class ResetPasswordRequest
{
    public string Token { set; get; } = string.Empty;
    public string NewPassword { set; get; } = string.Empty;
}
