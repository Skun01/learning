using Application.DTOs.Deck;

namespace Application.IServices;

public interface IDeckService
{
    Task<bool> CreateDeckAsync(CreateDeckRequest request, string userId);
}
