using Application.IServices.IInternal;
using Domain.Entities;

namespace Infrastructure.InternalServices;

public class TokenService : ITokenService
{
    public string GenerateAccessToken(User user)
    {
        throw new NotImplementedException();
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
