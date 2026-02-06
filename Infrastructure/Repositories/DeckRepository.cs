using Application.DTOs.Common;
using Application.DTOs.Deck;
using Application.IRepositories;
using Domain.Entities;
using Domain.Enums;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class DeckRepository : Repository<Deck>, IDeckRepository
{
    public DeckRepository(AppDbContext context) : base(context) {}

    public async Task<IEnumerable<Deck>> GetByFilterAsync(QueryDTO<SearchDeckQueryDTO> model, string userId)
    {
        var qr = _context.Decks.Where( d => d.CreatedBy == userId)
            .AsNoTracking()
            .AsQueryable();

        if(model.Query != null)
        {
            if (!string.IsNullOrWhiteSpace(model.Query.Keyword))
            {
                var keyword = model.Query.Keyword.Trim(); 
                qr = qr.Where(d => d.Name.Contains(keyword));
            }

            qr = model.Query.Type switch
            {
                "Grammar" => qr.Where(d => d.Type == DeckType.Grammar),
                "Vocabulary" => qr.Where(d => d.Type == DeckType.Vocabulary),
                _ => qr
            };
        }

        model.Total = await qr.CountAsync();

        qr = qr.OrderByDescending(d => d.CreatedAt);
        if(model.Query != null)
        {
            qr = qr.Skip(model.Query.PageSize * (model.Query.Page - 1))
                .Take(model.Query.PageSize);
        }

        return await qr.Include(d => d.User)
            .Include(d => d.GrammarCards)
            .Include(d => d.VocabularyCards)
            .AsSplitQuery()
            .ToListAsync();
    }

    // chỉ lấy thông tin cơ bản của card, không lấy ví dụ học liệu
    public async Task<Deck?> GetWithCardByIdAsync(string id)
    {
        return await _context.Decks.AsNoTracking()
            .Include(d => d.VocabularyCards)
            .Include(d => d.GrammarCards)
            .Include(d => d.User)
            .FirstOrDefaultAsync(d => d.Id == id);
    }

    public async Task<bool> IsExist(string id, DeckType type)
    {
        return await _context.Decks.AnyAsync(d => d.Id == id && d.Type == type);
    }
}
