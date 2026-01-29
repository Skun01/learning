using Application.DTOs.Auth;

namespace Application.IServices;

public interface IAuthService
{
    public Task<AuthDTO> LoginAsync(LoginRequest request);
    public Task<bool> RegisterAsync(RegisterRequest request);
    public Task<bool> SendResetPasswordEmailAsync(string email);
    public Task<bool> ResetPasswordAsync(ResetPasswordRequest request);
    public Task<AuthDTO> RefreshTokenAsync(string? refreshToken);
    public Task<bool> LogoutAsync(string? refreshToken);
}
