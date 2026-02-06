using Domain.Entities;

namespace Application.IRepositories;

public interface IVocabularyCardRepository : IRepository<VocabularyCard>
{
    public Task<IEnumerable<VocabularyCard>> GetAllByDeckId(string deckId);
    public Task<VocabularyCard?> GetFullInfoByIdAsync(string id);
}
