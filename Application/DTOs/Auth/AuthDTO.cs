using System.Text.Json.Serialization;

namespace Application.DTOs.Auth;

public class AuthDTO
{
    public string AccessToken { set; get; } = string.Empty;

    [JsonIgnore]
    public string RefreshToken { set; get; } = string.Empty;
}
