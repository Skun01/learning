using System.Net.Cache;
using Application.DTOs.VocabularyCard;

namespace Application.IServices;

public interface IVocabularyCardService
{
    Task<bool> CreateVocabularyCardAsync(CreateVocabularyRequest request, string userId);
    Task<IEnumerable<VocabularyCardDTO>> GetVocabularyListByDeckId(string deckId);
    Task<VocabularyCardDTO> GetCardByIdAsync(string id);
    Task<bool> UpdateCardAsync(UpdateVocabularyCardRequest request, string cardId, string userId);
    Task<bool> DeleteCardByIdAsync(string id, string userId);
}
