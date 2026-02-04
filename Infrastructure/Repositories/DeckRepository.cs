using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DeckRepository : Repository<Deck>, IDeckRepository
{
    public DeckRepository(AppDbContext context) : base(context) {}

    // chỉ lấy thông tin cơ bản của card, không lấy ví dụ học liệu
    public async Task<Deck?> GetWithCardByIdAsync(string id)
    {
        return await _context.Decks.AsNoTracking()
            .Include(d => d.VocabularyCards)
            .Include(d => d.GrammarCards)
            .Include(d => d.User)
            .FirstOrDefaultAsync(d => d.Id == id);
    }
}
