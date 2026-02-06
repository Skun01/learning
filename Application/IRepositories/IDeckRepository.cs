using Application.DTOs.Common;
using Application.DTOs.Deck;
using Domain.Entities;
using Domain.Enums;

namespace Application.IRepositories;

public interface IDeckRepository : IRepository<Deck>
{
    Task<Deck?> GetWithCardByIdAsync(string id);
    Task<IEnumerable<Deck>> GetByFilterAsync(QueryDTO<SearchDeckQueryDTO> model, string userId);
    Task<bool> IsExist(string id, DeckType type);
}
