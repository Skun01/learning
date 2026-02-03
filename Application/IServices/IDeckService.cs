using Application.DTOs.Deck;

namespace Application.IServices;

public interface IDeckService
{
    Task<bool> CreateDeckAsync(CreateDeckRequest request, string userId);
    Task<bool> UpdateDeckAsync(UpdateDeckRequest request, string userId, string deckId);
}
