using Application.DTOs.VocabularyCard;

namespace Application.IServices;

public interface IVocabularyCardService
{
    Task<bool> CreateVocabularyCardAsync(CreateVocabularyRequest request, string userId);
}
