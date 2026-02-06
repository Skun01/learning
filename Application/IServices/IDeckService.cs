using Application.DTOs.Common;
using Application.DTOs.Deck;

namespace Application.IServices;

public interface IDeckService
{
    Task<bool> CreateDeckAsync(CreateDeckRequest request, string userId);
    Task<bool> UpdateDeckAsync(UpdateDeckRequest request, string userId, string deckId);
    Task<bool> DeleteDeckAsync(string id, string userId);
    Task<DeckDTO> GetDeckSummaryContent(string id);
    Task<IEnumerable<DeckSummaryDTO>> GetMyDeckByFilterAsync(QueryDTO<SearchDeckQueryDTO> query, string userId);
}
