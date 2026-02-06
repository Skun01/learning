using Domain.Entities;

namespace Application.IRepositories;

public interface IExampleSentenceRepository : IRepository<ExampleSentence>
{
    Task AddRangeAsync(IEnumerable<ExampleSentence> examples);
}
