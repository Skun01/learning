using Domain.Entities;

namespace Application.IRepositories;

public interface IDeckRepository : IRepository<Deck>
{
    Task<Deck?> GetWithCardByIdAsync(string id);
}
