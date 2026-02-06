using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class VocabularyCardRepository : Repository<VocabularyCard>, IVocabularyCardRepository
{
    public VocabularyCardRepository(AppDbContext context) : base(context) {}
}
