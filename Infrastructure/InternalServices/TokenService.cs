using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Application.IServices.IInternal;
using Application.Settings;
using Domain.Entities;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.InternalServices;

public class TokenService : ITokenService
{
    private readonly JwtSettings _settings;
    private readonly SymmetricSecurityKey _secretKey;
    public TokenService(IOptions<JwtSettings> options)
    {
        _settings = options.Value;
        _secretKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(_settings.Key)
        );
    }

    public string GenerateAccessToken(User user)
    {
        var issuer = _settings.Issuer;
        var audience = _settings.Audience;
        var expireHours = _settings.ExpireHours;

        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddHours(expireHours),
            Issuer = issuer,
            Audience = audience,
            SigningCredentials = new SigningCredentials(
                _secretKey,
                SecurityAlgorithms.HmacSha256Signature
            )
        };

        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }

    public string GenerateRandomToken()
    {
        throw new NotImplementedException();
    }

    public string GenerateRefreshToken()
    {
        throw new NotImplementedException();
    }
}
