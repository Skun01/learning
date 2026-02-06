using Application.IRepositories;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Infrastructure.Repositories;

public class ExampleSentenceRepository : Repository<ExampleSentence>, IExampleSentenceRepository
{
    public ExampleSentenceRepository(AppDbContext context) : base(context) {}

    public async Task AddRangeAsync(IEnumerable<ExampleSentence> examples)
    {
        await _context.AddRangeAsync(examples);
    }
}
