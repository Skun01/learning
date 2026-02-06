using Application.DTOs.Common;
using Application.DTOs.Deck;
using Domain.Entities;

namespace Application.IRepositories;

public interface IDeckRepository : IRepository<Deck>
{
    Task<Deck?> GetWithCardByIdAsync(string id);
    Task<IEnumerable<Deck>> GetByFilterAsync(QueryDTO<SearchDeckQueryDTO> model, string userId);
}
