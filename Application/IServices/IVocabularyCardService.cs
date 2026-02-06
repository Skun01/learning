using Application.DTOs.VocabularyCard;

namespace Application.IServices;

public interface IVocabularyCardService
{
    Task<bool> CreateVocabularyCardAsync(CreateVocabularyRequest request, string userId);
    Task<IEnumerable<VocabularyCardDTO>> GetVocabularyListByDeckId(string deckId);
}
